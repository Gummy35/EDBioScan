using ExoScan.Requirements;
using ExoScan.RuleSets;
using ExoScan.StellarStructs;
using static ExoScan.CodexData.CodexIds;
using static ExoScan.StellarStructs.Planet;


namespace ExoScan
{
    public class BioForecast
    {
        // Cache structure: Dictionary<planetName, Dictionary<genus, (needsRefresh, result)>>
        private Dictionary<int, Dictionary<GenusEnum, (bool needsRefresh, ScanCacheEntry? entry)>> planetCache = new();

        public StarSystem CurrentSystem { get; private set; }

        public BioForecast()
        {
        }

        /// <summary>
        /// Checks for parent stars which are black holes.Bios nearly always base their color on the parent star, but
        /// when the parent star is a black hole, the orbiting stars can provide color instead.
        ///:param star: The star to check for a parent black hole
        ///:param body: The planet data to ensure the star is a valid parent star
        ///:return: True if the star has a parent black hole and the body is orbiting it
        /// </summary>

        public bool ParentIsH(Star star, Planet body)
        {
            var parentStars = body.GetParentStars();
            // if body is orbiting a star
            if (parentStars.Count > 0)
            {
                // and this star is a black hole,
                var parentStar = parentStars[0];
                if (parentStar.StarType == "H")
                {
                    // check if the star orbits as well the black hole
                    if (star.Parents.Any(b => b.Key == parentStar.BodyId))
                        return true;
                    else
                    {
                        // check if the block hole is orbiting a barycentre
                        var bhParentBarycentre = parentStar.Parents
                                        .Where(p => p.Value == Enums.BodyType.Barycenter)
                                        .Select(p => p.Key)
                                        .ToHashSet();
                        // check if the black hole is orbiting a barycentre, and the checked star orbit the same barycentre
                        if (bhParentBarycentre.Count > 0 && star.Parents.Any(b => b.Key == bhParentBarycentre.First()))
                            return true;
                    }
                }
            }
            return false;
        }

        public ScanCacheEntry ValueEstimate(Planet body, GenusEnum genus)
        {
            var hasChanges = false;

            // Initialize planet cache if missing
            if (string.IsNullOrEmpty(body.Name))
                return null;
            if (!planetCache.TryGetValue(body.BodyId, out var genusCache))
            {
                genusCache = new Dictionary<GenusEnum, (bool needsRefresh, ScanCacheEntry entry)>();
                planetCache[body.BodyId] = genusCache;
            }

            // Return existing cache entry if no refresh is required
            if (genusCache.TryGetValue(genus, out var cachedEntry) && !cachedEntry.needsRefresh)
                return cachedEntry.Item2;

            // Initialize empty cache entry
            genusCache[genus] = (true, null);

            // No star yet, postpone analysis
            if (CurrentSystem.Stars.Count == 0)
            {
                return null;
            }

            // ------------------------------------------------------------
            // Case 1: Flora data already exists for this planet and genus
            // ------------------------------------------------------------
            if (body.Floras.Count > 0)
            {
                if (!body.Floras.TryGetValue(genus, out var flora))
                {
                    //                    genusCache[genus] = (false, null);
                    return null;
                }
                if (flora.Species != 0)
                {
                    var floraEntry = CreateFloraEntry(body, genus, flora);
                    genusCache[genus] = (false, floraEntry);
                    return floraEntry;
                }
            }

            // ------------------------------------------------------------
            // Case 2: Evaluate biogenus rules dynamically
            // ------------------------------------------------------------
            var possibleSpecies = EvaluateSpeciesRules(body, genus);

            if (possibleSpecies.Count > 0)
            {
                ApplyColorFilters(body, genus, possibleSpecies);

                if (possibleSpecies.Count > 0)
                {
                    var sortedSpecies = SortFinalSpecies(genus, possibleSpecies);

                    genusCache[genus] = (false, CreateCacheEntryFromResults(genus, sortedSpecies));
                }
            }

            // Final cleanup: reset if refresh was flagged
            if (genusCache[genus].needsRefresh)
                genusCache[genus] = (false, null);

            return genusCache[genus].entry;
        }

        #region --- Helper Methods ---

        // Creates a simple ScanCacheEntry when flora data is directly available
        private ScanCacheEntry CreateFloraEntry(Planet body, GenusEnum genus, Flora flora)
        {
            var rule = BioRules.Rules[genus][(ushort)flora.Species];
            var color = flora.Color;

            return new ScanCacheEntry
            {
                Genus = genus,
                Display = $"{GenusData.GetGenus(genus).Name}{(string.IsNullOrEmpty(color) ? "" : $" - {color}")}",
                MinValue = rule.Value,
                MaxValue = rule.Value,
                Species = new()
                {
                    [flora.Species] = new ScanCacheEntry.SpeciesDataEntry
                    {
                        Value = rule.Value,
                        Variants = new() { color }
                    }
                }
            };
        }

        // Runs the complete ruleset evaluation for all possible species
        private Dictionary<ushort, HashSet<string>> EvaluateSpeciesRules(Planet body, GenusEnum genus)
        {
            var possible = new Dictionary<ushort, HashSet<string>>();

            foreach (var (species, data) in BioRules.Rules[genus])
            {
                foreach (var ruleset in data.Rulesets)
                {
                    bool match =
                        (ruleset.Atmosphere == null || ruleset.Atmosphere.Matches(body)) &&
                        (ruleset.AtmosphereComponent == null || AtmosphereRequirement.CheckComponents(ruleset.AtmosphereComponent, body)) &&
                        (ruleset.MaxGravity == null || ruleset.MaxGravity > body.Gravity / 9.797759) &&
                        (ruleset.MinGravity == null || ruleset.MinGravity < body.Gravity / 9.797759) &&
                        (ruleset.MaxTemperature == null || ruleset.MaxTemperature > body.Temperature) &&
                        (ruleset.MinTemperature == null || ruleset.MinTemperature < body.Temperature) &&
                        (ruleset.MaxPressure == null || ruleset.MaxPressure > body.Pressure / 101231.656250) &&
                        (ruleset.MinPressure == null || ruleset.MinPressure < body.Pressure / 101231.656250) &&
                        (ruleset.MaxOrbitalPeriod == null || ruleset.MaxOrbitalPeriod > body.OrbitalPeriod) &&
                        (ruleset.Volcanism == null || ruleset.Volcanism.Matches(body)) &&
                        (ruleset.BodyType == null || ruleset.BodyType.Matches(body)) &&
                        (ruleset.Region == null || ruleset.Region.Matches(body)) &&
                        (!ruleset.Guardian || RegionRequirement.InGuardianNebulae(body)) &&
                        (ruleset.Tuber == null || RegionRequirement.InTuberSector(ruleset.Tuber, body)) &&
                        (ruleset.Bodies == null || ruleset.Bodies.Matches(body)) &&
                        (ruleset.ParentStar == null || ruleset.ParentStar.MatchesParent(body)) &&
                        (ruleset.Star == null || ruleset.Star.MatchesSystemStars(body)) &&
                        (ruleset.Nebula == null || Nebulae.InNebula(body, ruleset.Nebula)) &&
                        (ruleset.Distance == null || body.DistanceFromArrivalLS < ruleset.Distance);

                    if (match)
                        possible[species] = new();
                }
            }

            return possible;
        }

        // Applies genus and species color-based filtering rules
        private void ApplyColorFilters(Planet body, GenusEnum genus, Dictionary<ushort, HashSet<string>> possibleSpecies)
        {
            var genusData = GenusData.GetGenus(genus);
            var eliminated = new HashSet<ushort>();
            var parentStars = body.GetParentStars();

            if (genusData.Colors == null) return;

            // Species-specific color filters
            if (genusData.Colors.Species?.Count > 0)
            {
                foreach (var species in possibleSpecies.Keys.ToList())
                {
                    if (!genusData.Colors.Species.TryGetValue(species, out var speciesColors))
                        continue;

                    if (speciesColors.Star?.Count > 0)
                    {
                        foreach (var star in parentStars)
                        {
                            foreach (var (starType, color) in speciesColors.Star)
                            {
                                if (StarRequirement.StarCheck(starType, star.StarType))
                                {
                                    possibleSpecies[species].Add(color);
                                    break;
                                }
                            }
                        }

                        foreach (var star in CurrentSystem.Stars)
                        {
                            if (parentStars.Contains(star))
                                continue;
                            if (star.DistanceFromArrivalLS == 0 || ParentIsH(star, body))
                            {
                                foreach (var starTypeEntry in speciesColors.Star)
                                {
                                    var starType = starTypeEntry.Key;
                                    if (star.StarType != null && StarRequirement.StarCheck(starType, star.StarType))
                                    {
                                        possibleSpecies[species].Add(speciesColors.Star[starType]);
                                        break;
                                    }
                                }

                            }
                        }
                    }
                    else if (speciesColors.Element?.Count > 0)
                    {
                        foreach (var (element, color) in speciesColors.Element)
                        {
                            if (body.Materials.ContainsKey(element))
                                possibleSpecies[species].Add(color);
                        }
                    }

                    if (possibleSpecies[species].Count == 0)
                        eliminated.Add(species);
                }

                foreach (var e in eliminated)
                    possibleSpecies.Remove(e);
            }
            // Global genus color rules
            else if (genusData.Colors.Star?.Count > 0)
            {
                var foundColors = new HashSet<string>();

                foreach (var star in parentStars)
                {
                    foreach (var (starType, color) in genusData.Colors.Star)
                    {
                        if (StarRequirement.StarCheck(starType, star.StarType))
                            foundColors.Add(color);
                    }
                }

                foreach (var star in CurrentSystem.Stars)
                {
                    if (parentStars.Contains(star))
                    {
                        continue;
                    }

                    if (star.DistanceFromArrivalLS == 0 || ParentIsH(star, body))
                    {
                        foreach (var starTypeEntry in genusData.Colors.Star)
                        {
                            var starType = starTypeEntry.Key;
                            if (star.StarType != null && StarRequirement.StarCheck(starType, star.StarType))
                            {
                                foundColors.Add(genusData.Colors.Star[starType]);
                                break;
                            }
                        }
                    }
                }


                if (foundColors.Count == 0)
                    possibleSpecies.Clear();
                else
                    foreach (var s in possibleSpecies.Keys)
                        possibleSpecies[s].UnionWith(foundColors);
            }
        }

        // Produces a sorted list of final (species, variants) pairs
        private List<(ushort species, List<string> variants)> SortFinalSpecies(GenusEnum genus, Dictionary<ushort, HashSet<string>> possibleSpecies)
        {
            return possibleSpecies
                .ToDictionary(k => k.Key, v => v.Value.OrderBy(x => x).ToList())
                .OrderBy(s => BioRules.Rules[genus][s.Key].Value)
                .Select(s => (s.Key, s.Value))
                .ToList();
        }

        // Creates the final ScanCacheEntry based on filtered and sorted species
        private ScanCacheEntry CreateCacheEntryFromResults(GenusEnum genus, List<(ushort species, List<string> variants)> sortedSpecies)
        {
            var genusName = GenusData.Data[genus].Name;
            var localizedSpecies = new Dictionary<int, ScanCacheEntry.SpeciesDataEntry>();

            if (sortedSpecies.Count == 1)
            {
                var (species, variants) = sortedSpecies[0];
                var rule = BioRules.Rules[genus][species];
                var display = rule.Name + (variants.Count == 1 ? $" - {variants[0]}" : "");

                if (variants.Count > 1)
                {
                    localizedSpecies[species] = new()
                    {
                        Value = rule.Value,
                        Variants = variants
                    };
                }

                return new ScanCacheEntry
                {
                    Genus = genus,
                    Display = display,
                    MinValue = rule.Value,
                    MaxValue = rule.Value,
                    Species = localizedSpecies
                };
            }
            else
            {
                string color = DetermineCommonColor(sortedSpecies);
                int minValue = BioRules.Rules[genus][sortedSpecies[0].species].Value;
                int maxValue = BioRules.Rules[genus][sortedSpecies[^1].species].Value;

                foreach (var (sp, vars) in sortedSpecies)
                {
                    var rule = BioRules.Rules[genus][sp];
                    localizedSpecies[sp] = new()
                    {
                        Value = rule.Value,
                        Variants = vars
                    };
                }

                return new ScanCacheEntry
                {
                    Genus = genus,
                    Display = $"{genusName}{(string.IsNullOrEmpty(color) ? "" : $" - {color}")}",
                    MinValue = minValue,
                    MaxValue = maxValue,
                    Species = localizedSpecies
                };
            }
        }

        // Finds a common color across all species, if any
        private string DetermineCommonColor(List<(ushort species, List<string> variants)> sortedSpecies)
        {
            string color = "";

            foreach (var (_, colors) in sortedSpecies)
            {
                if (colors.Count == 0) continue;
                if (string.IsNullOrEmpty(color)) color = colors[0];
                else if (colors[0] != color) return "";
            }

            return color;
        }

        #endregion


        public List<ScanCacheEntry> GetPossibleValues(Planet body)
        {
            if (body.BioSignals == 0)
                return [];

            var genuses = body.Floras.Count == 0
                ? GenusData.Data.Keys.ToList()
                : body.Floras.Keys.ToList();

            // Sync cache with planet floras
            if (body.Floras.Count > 0 && planetCache.TryGetValue(body.BodyId, out var genusCache))
            {
                foreach (var genus in genusCache.Keys.Except(body.Floras.Keys).ToList())
                {
                    genusCache.Remove(genus);
                }

                foreach (var (genus, flora) in body.Floras)
                {
                    if (flora.Species == 0) continue;

                    if (!genusCache.TryGetValue(genus, out var cacheEntry))
                        continue;

                    if (cacheEntry.entry == null)
                    {
                        cacheEntry = (true, null);
                        genusCache[genus] = cacheEntry;
                    }
                    var possibleSpecies = cacheEntry.entry?.Species;

                    // Reset species cache if invalid
                    if (possibleSpecies != null && (possibleSpecies.Count != 1 || possibleSpecies.Keys.First() != flora.Species))
                    {
                        possibleSpecies.Clear();
                        genusCache[genus] = (false, CreateFloraEntry(body, genus, flora));
                    }
                }
            }

            // Compute valid scan results
            return genuses
                .Select(genus => ValueEstimate(body, genus))
                .Where(res => res?.MinValue > 0)
                .ToList();
        }


        internal void SetSystem(StarSystem starSystem)
        {
            if (CurrentSystem != starSystem)
            {
                planetCache.Clear();
                CurrentSystem = starSystem;
            }
        }

        internal void InvalidateCache(int bodyId)
        {
            if (planetCache.ContainsKey(bodyId))
                planetCache.Remove(bodyId);
        }
    }
}