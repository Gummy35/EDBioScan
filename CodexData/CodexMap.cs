using ExoScan.Enums;
using ExoScan.RuleSets;
using static ExoScan.CodexData.CodexIds;
using static ExoScan.CodexData.CodexIds.Genus;
namespace ExoScan.CodexData
{
    public static class CodexMap
    {
        public static readonly Dictionary<string, ushort> FromString = new(StringComparer.OrdinalIgnoreCase)
        {
            ["$Codex_Ent_Cone_Name;"] = Cone.Species.Root,
            ["$Codex_Ent_Ground_Struct_Ice_Name;"] = GroundStructIce.Species.Root,
            ["$Codex_Ent_Vents_Name;"] = Vents.Species.Root,
            ["$Codex_Ent_Aleoids_01_Name;"] = Aleoids.Species.Aleoids01,
            ["$Codex_Ent_Aleoids_02_Name;"] = Aleoids.Species.Aleoids02,
            ["$Codex_Ent_Aleoids_03_Name;"] = Aleoids.Species.Aleoids03,
            ["$Codex_Ent_Aleoids_04_Name;"] = Aleoids.Species.Aleoids04,
            ["$Codex_Ent_Aleoids_05_Name;"] = Aleoids.Species.Aleoids05,
            ["$Codex_Ent_Sphere_Name;"] = Sphere.Species.Root,
            ["$Codex_Ent_SphereABCD_01_Name;"] = Sphere.Species.SphereABCD01,
            ["$Codex_Ent_SphereABCD_02_Name;"] = Sphere.Species.SphereABCD02,
            ["$Codex_Ent_SphereABCD_03_Name;"] = Sphere.Species.SphereABCD03,
            ["$Codex_Ent_SphereEFGH_01_Name;"] = Sphere.Species.SphereEFGH01,
            ["$Codex_Ent_SphereEFGH_02_Name;"] = Sphere.Species.SphereEFGH02,
            ["$Codex_Ent_SphereEFGH_03_Name;"] = Sphere.Species.SphereEFGH03,
            ["$Codex_Ent_SphereEFGH_Name;"] = Sphere.Species.SphereEFGH,
            ["$Codex_Ent_Bacterial_01_Name;"] = Bacterial.Species.Bacterial01,
            ["$Codex_Ent_Bacterial_02_Name;"] = Bacterial.Species.Bacterial02,
            ["$Codex_Ent_Bacterial_03_Name;"] = Bacterial.Species.Bacterial03,
            ["$Codex_Ent_Bacterial_04_Name;"] = Bacterial.Species.Bacterial04,
            ["$Codex_Ent_Bacterial_05_Name;"] = Bacterial.Species.Bacterial05,
            ["$Codex_Ent_Bacterial_06_Name;"] = Bacterial.Species.Bacterial06,
            ["$Codex_Ent_Bacterial_07_Name;"] = Bacterial.Species.Bacterial07,
            ["$Codex_Ent_Bacterial_08_Name;"] = Bacterial.Species.Bacterial08,
            ["$Codex_Ent_Bacterial_09_Name;"] = Bacterial.Species.Bacterial09,
            ["$Codex_Ent_Bacterial_10_Name;"] = Bacterial.Species.Bacterial10,
            ["$Codex_Ent_Bacterial_11_Name;"] = Bacterial.Species.Bacterial11,
            ["$Codex_Ent_Bacterial_12_Name;"] = Bacterial.Species.Bacterial12,
            ["$Codex_Ent_Bacterial_13_Name;"] = Bacterial.Species.Bacterial13,
            ["$Codex_Ent_Seed_Name;"] = Brancae.Species.Seed,
            ["$Codex_Ent_SeedABCD_01_Name;"] = Brancae.Species.SeedABCD01,
            ["$Codex_Ent_SeedABCD_02_Name;"] = Brancae.Species.SeedABCD02,
            ["$Codex_Ent_SeedABCD_03_Name;"] = Brancae.Species.SeedABCD03,
            ["$Codex_Ent_SeedEFGH_01_Name;"] = Brancae.Species.SeedEFGH01,
            ["$Codex_Ent_SeedEFGH_02_Name;"] = Brancae.Species.SeedEFGH02,
            ["$Codex_Ent_SeedEFGH_03_Name;"] = Brancae.Species.SeedEFGH03,
            ["$Codex_Ent_SeedEFGH_Name;"] = Brancae.Species.SeedEFGH,
            ["$Codex_Ent_Cactoid_01_Name;"] = Cactoid.Species.Cactoid01,
            ["$Codex_Ent_Cactoid_02_Name;"] = Cactoid.Species.Cactoid02,
            ["$Codex_Ent_Cactoid_03_Name;"] = Cactoid.Species.Cactoid03,
            ["$Codex_Ent_Cactoid_04_Name;"] = Cactoid.Species.Cactoid04,
            ["$Codex_Ent_Cactoid_05_Name;"] = Cactoid.Species.Cactoid05,
            ["$Codex_Ent_Clypeus_01_Name;"] = Clypeus.Species.Clypeus01,
            ["$Codex_Ent_Clypeus_02_Name;"] = Clypeus.Species.Clypeus02,
            ["$Codex_Ent_Clypeus_03_Name;"] = Clypeus.Species.Clypeus03,
            ["$Codex_Ent_Conchas_01_Name;"] = Conchas.Species.Conchas01,
            ["$Codex_Ent_Conchas_02_Name;"] = Conchas.Species.Conchas02,
            ["$Codex_Ent_Conchas_03_Name;"] = Conchas.Species.Conchas03,
            ["$Codex_Ent_Conchas_04_Name;"] = Conchas.Species.Conchas04,
            ["$Codex_Ent_Electricae_01_Name;"] = Electricae.Species.Electricae01,
            ["$Codex_Ent_Electricae_02_Name;"] = Electricae.Species.Electricae02,
            ["$Codex_Ent_Fonticulus_01_Name;"] = Fonticulus.Species.Fonticulus01,
            ["$Codex_Ent_Fonticulus_02_Name;"] = Fonticulus.Species.Fonticulus02,
            ["$Codex_Ent_Fonticulus_03_Name;"] = Fonticulus.Species.Fonticulus03,
            ["$Codex_Ent_Fonticulus_04_Name;"] = Fonticulus.Species.Fonticulus04,
            ["$Codex_Ent_Fonticulus_05_Name;"] = Fonticulus.Species.Fonticulus05,
            ["$Codex_Ent_Fonticulus_06_Name;"] = Fonticulus.Species.Fonticulus06,
            ["$Codex_Ent_Shrubs_01_Name;"] = Shrubs.Species.Shrubs01,
            ["$Codex_Ent_Shrubs_02_Name;"] = Shrubs.Species.Shrubs02,
            ["$Codex_Ent_Shrubs_03_Name;"] = Shrubs.Species.Shrubs03,
            ["$Codex_Ent_Shrubs_04_Name;"] = Shrubs.Species.Shrubs04,
            ["$Codex_Ent_Shrubs_05_Name;"] = Shrubs.Species.Shrubs05,
            ["$Codex_Ent_Shrubs_06_Name;"] = Shrubs.Species.Shrubs06,
            ["$Codex_Ent_Shrubs_07_Name;"] = Shrubs.Species.Shrubs07,
            ["$Codex_Ent_Fumerolas_01_Name;"] = Fumerolas.Species.Fumerolas01,
            ["$Codex_Ent_Fumerolas_02_Name;"] = Fumerolas.Species.Fumerolas02,
            ["$Codex_Ent_Fumerolas_03_Name;"] = Fumerolas.Species.Fumerolas03,
            ["$Codex_Ent_Fumerolas_04_Name;"] = Fumerolas.Species.Fumerolas04,
            ["$Codex_Ent_Fungoids_01_Name;"] = Fungoids.Species.Fungoids01,
            ["$Codex_Ent_Fungoids_02_Name;"] = Fungoids.Species.Fungoids02,
            ["$Codex_Ent_Fungoids_03_Name;"] = Fungoids.Species.Fungoids03,
            ["$Codex_Ent_Fungoids_04_Name;"] = Fungoids.Species.Fungoids04,
            ["$Codex_Ent_Osseus_01_Name;"] = Osseus.Species.Osseus01,
            ["$Codex_Ent_Osseus_02_Name;"] = Osseus.Species.Osseus02,
            ["$Codex_Ent_Osseus_03_Name;"] = Osseus.Species.Osseus03,
            ["$Codex_Ent_Osseus_04_Name;"] = Osseus.Species.Osseus04,
            ["$Codex_Ent_Osseus_05_Name;"] = Osseus.Species.Osseus05,
            ["$Codex_Ent_Osseus_06_Name;"] = Osseus.Species.Osseus06,
            ["$Codex_Ent_Recepta_01_Name;"] = Recepta.Species.Recepta01,
            ["$Codex_Ent_Recepta_02_Name;"] = Recepta.Species.Recepta02,
            ["$Codex_Ent_Recepta_03_Name;"] = Recepta.Species.Recepta03,
            ["$Codex_Ent_Stratum_01_Name;"] = Stratum.Species.Stratum01,
            ["$Codex_Ent_Stratum_02_Name;"] = Stratum.Species.Stratum02,
            ["$Codex_Ent_Stratum_03_Name;"] = Stratum.Species.Stratum03,
            ["$Codex_Ent_Stratum_04_Name;"] = Stratum.Species.Stratum04,
            ["$Codex_Ent_Stratum_05_Name;"] = Stratum.Species.Stratum05,
            ["$Codex_Ent_Stratum_06_Name;"] = Stratum.Species.Stratum06,
            ["$Codex_Ent_Stratum_07_Name;"] = Stratum.Species.Stratum07,
            ["$Codex_Ent_Stratum_08_Name;"] = Stratum.Species.Stratum08,
            ["$Codex_Ent_Tube_Name;"] = Tube.Species.Root,
            ["$Codex_Ent_TubeABCD_01_Name;"] = Tube.Species.TubeABCD01,
            ["$Codex_Ent_TubeABCD_02_Name;"] = Tube.Species.TubeABCD02,
            ["$Codex_Ent_TubeABCD_03_Name;"] = Tube.Species.TubeABCD03,
            ["$Codex_Ent_TubeEFGH_01_Name;"] = Tube.Species.TubeEFGH01,
            ["$Codex_Ent_TubeEFGH_02_Name;"] = Tube.Species.TubeEFGH02,
            ["$Codex_Ent_TubeEFGH_03_Name;"] = Tube.Species.TubeEFGH03,
            ["$Codex_Ent_TubeEFGH_Name;"] = Tube.Species.TubeEFGH,
            ["$Codex_Ent_Tubus_01_Name;"] = Tubus.Species.Tubus01,
            ["$Codex_Ent_Tubus_02_Name;"] = Tubus.Species.Tubus02,
            ["$Codex_Ent_Tubus_03_Name;"] = Tubus.Species.Tubus03,
            ["$Codex_Ent_Tubus_04_Name;"] = Tubus.Species.Tubus04,
            ["$Codex_Ent_Tubus_05_Name;"] = Tubus.Species.Tubus05,
            ["$Codex_Ent_Tussocks_01_Name;"] = Tussocks.Species.Tussocks01,
            ["$Codex_Ent_Tussocks_02_Name;"] = Tussocks.Species.Tussocks02,
            ["$Codex_Ent_Tussocks_03_Name;"] = Tussocks.Species.Tussocks03,
            ["$Codex_Ent_Tussocks_04_Name;"] = Tussocks.Species.Tussocks04,
            ["$Codex_Ent_Tussocks_05_Name;"] = Tussocks.Species.Tussocks05,
            ["$Codex_Ent_Tussocks_06_Name;"] = Tussocks.Species.Tussocks06,
            ["$Codex_Ent_Tussocks_07_Name;"] = Tussocks.Species.Tussocks07,
            ["$Codex_Ent_Tussocks_08_Name;"] = Tussocks.Species.Tussocks08,
            ["$Codex_Ent_Tussocks_09_Name;"] = Tussocks.Species.Tussocks09,
            ["$Codex_Ent_Tussocks_10_Name;"] = Tussocks.Species.Tussocks10,
            ["$Codex_Ent_Tussocks_11_Name;"] = Tussocks.Species.Tussocks11,
            ["$Codex_Ent_Tussocks_12_Name;"] = Tussocks.Species.Tussocks12,
            ["$Codex_Ent_Tussocks_13_Name;"] = Tussocks.Species.Tussocks13,
            ["$Codex_Ent_Tussocks_14_Name;"] = Tussocks.Species.Tussocks14,
            ["$Codex_Ent_Tussocks_15_Name;"] = Tussocks.Species.Tussocks15,
        };

        public static readonly Dictionary<string, GenusEnum> GenusFromString = new(StringComparer.OrdinalIgnoreCase)
        {
            ["$Codex_Ent_Cone_Name;"] = GenusEnum.Cone,
            ["$Codex_Ent_Ground_Struct_Ice_Name;"] = GenusEnum.GroundStructIce,
            ["$Codex_Ent_Vents_Name;"] = GenusEnum.Vents,
            ["$Codex_Ent_Aleoids_Genus_Name;"] = GenusEnum.Aleoids,
            ["$Codex_Ent_Sphere_Name;"] = GenusEnum.Sphere,
            ["$Codex_Ent_Bacterial_Genus_Name;"] = GenusEnum.Bacterial,
            ["$Codex_Ent_Brancae_Name;"] = GenusEnum.Brancae,
            ["$Codex_Ent_Cactoid_Genus_Name;"] = GenusEnum.Cactoid,
            ["$Codex_Ent_Clypeus_Genus_Name;"] = GenusEnum.Clypeus,
            ["$Codex_Ent_Conchas_Genus_Name;"] = GenusEnum.Conchas,
            ["$Codex_Ent_Electricae_Genus_Name;"] = GenusEnum.Electricae,
            ["$Codex_Ent_Fonticulus_Genus_Name;"] = GenusEnum.Fonticulus,
            ["$Codex_Ent_Shrubs_Genus_Name;"] = GenusEnum.Shrubs,
            ["$Codex_Ent_Fumerolas_Genus_Name;"] = GenusEnum.Fumerolas,
            ["$Codex_Ent_Fungoids_Genus_Name;"] = GenusEnum.Fungoids,
            ["$Codex_Ent_Osseus_Genus_Name;"] = GenusEnum.Osseus,
            ["$Codex_Ent_Recepta_Genus_Name;"] = GenusEnum.Recepta,
            ["$Codex_Ent_Stratum_Genus_Name;"] = GenusEnum.Stratum,
            ["$Codex_Ent_Stratum_04_Name;"] = GenusEnum.Aranaemus,
            ["$Codex_Ent_Tube_Name;"] = GenusEnum.Tube,
            ["$Codex_Ent_Tubus_Genus_Name;"] = GenusEnum.Tubus,
            ["$Codex_Ent_Tussocks_Genus_Name;"] = GenusEnum.Tussocks,
        };


        public static readonly Dictionary<ushort, string> ToString = CreateReverse();

        private static Dictionary<ushort, string> CreateReverse()
        {
            var d = new Dictionary<ushort, string>();
            foreach (var kv in FromString) d[(ushort)kv.Value] = kv.Key;
            return d;
        }

        public static bool TryFromString(string key, out ushort id) => FromString.TryGetValue(key, out id);

        public static bool TryToString(ushort id, out string key) => ToString.TryGetValue(id, out key);



        public static readonly Dictionary<GenusEnum, string> GenusToString = CreateReverseGenus();
        private static Dictionary<GenusEnum, string> CreateReverseGenus()
        {
            var d = new Dictionary<GenusEnum, string>();
            foreach (var kv in FromString) d[(GenusEnum)kv.Value] = kv.Key;
            return d;
        }
        public static bool TryGenusFromString(string key, out GenusEnum id) => GenusFromString.TryGetValue(key, out id);

        public static bool TryGenusToString(GenusEnum id, out string key) => GenusToString.TryGetValue(id, out key);


        public static IEnumerable<ushort> EnumerateSpeciesOfGenus(GenusEnum genus)
        {
            ushort gid = (ushort)genus;
            foreach (var kv in FromString)
            {
                if ((ushort)(kv.Value >> 8) == gid) yield return kv.Value;
            }
        }

        /// <summary>
        /// Get the appropriate genus, species, and variant strings from the final species/variant identifier
        /// </summary>
        /// <param name="Name">The complete species/variant identifier</param>
        /// <returns>Tuple of the genus, species, and variant strings</returns>
        public static bool ParseVariant(string Name, out (GenusEnum? genus, int species, string variant) result)
        {
            GenusEnum? genus = null;
            if (FromString.ContainsKey(Name))
            {
                var species = FromString[Name];
                genus = (GenusEnum)(FromString[Name] >> 8);
                result = (genus, species, "");
                return true;
            }

            foreach (var kv in FromString)
            {
                var species = kv.Value;
                var search = kv.Key.Replace("Name;", "");
                if (Name.StartsWith(search))
                {
                    var color = "";
                    // Get the species part
                    genus = (GenusEnum)(species >> 8);
                    var speciesIdx = species & 0xFF;
                    var colorType = Name.Split(search)[1].Split("_Name")[0].ToLowerInvariant();
                    if (Enum.TryParse<StarType>(colorType, ignoreCase: true, out var starType))
                    {
                        if (speciesIdx == 0)
                        {
                            if (GenusData.HasGenusLevelColors(genus.Value))
                                color = GenusData.GetGenusColor(genus.Value, starType);
                        }
                        else
                        {
                            if (GenusData.HasSpeciesLevelColors(genus.Value))
                            {
                                var colors = GenusData.Data[genus.Value].Colors.Species;
                                if (colors.ContainsKey(kv.Value))
                                    colors[species].Star?.TryGetValue(starType, out color);
                            }
                        }
                    }
                    else
                    {
                        if (GenusData.HasSpeciesLevelColors(genus.Value))
                        {
                            var colors = GenusData.Data[genus.Value].Colors.Species;
                            if (colors.ContainsKey(kv.Value))
                                colors[kv.Value].Element?.TryGetValue(colorType, out color);
                        }
                    }
                    if (!string.IsNullOrEmpty(color))
                    {
                        result = (genus, species, color);
                        return true;
                    }
                }
            }
            result = (genus, 0, "");
            return false;
        }
    }
}