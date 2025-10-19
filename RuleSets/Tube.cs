using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Tube species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Tube = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Tube] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Tube.Species.Root] = new SpeciesRules
                {
                    Name = "Roseum Sinuous Tubers",
                    Value = 1514500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.FromStrings( "rocky magma" ),
                            Tuber = new List<string> { "Galactic Center", "Odin A", "Ryker B" },
                        }
                    }
                }
,
                [Genus.Tube.Species.TubeABCD01] = new SpeciesRules
                {
                    Name = "Prasinum Sinuous Tubers",
                    Value = 1514500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "High metal content body", "Rocky body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.Any,
                            Tuber = new List<string> { "Inner S-C Arm B 1" },
                        }
,
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "High metal content body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.FromStrings( "major rocky magma", "major silicate vapour" ),
                            Tuber = new List<string> { "Inner S-C Arm D", "Norma Expanse B", "Odin B" },
                        }
,
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "High metal content body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.FromStrings( "major rocky magma", "major silicate vapour" ),
                            Region = RegionRequirement.FromStrings( "empyrean-straits" ),
                        }
                    }
                }
,
                [Genus.Tube.Species.TubeABCD02] = new SpeciesRules
                {
                    Name = "Albidum Sinuous Tubers",
                    Value = 1514500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            MaxOrbitalPeriod = 86400,
                            Volcanism = VolcanismRequirement.FromStrings( "major silicate vapour", "major metallic magma" ),
                            Tuber = new List<string> { "Inner S-C Arm B 2", "Inner S-C Arm D", "Trojan Belt" },
                        }
                    }
                }
,
                [Genus.Tube.Species.TubeABCD03] = new SpeciesRules
                {
                    Name = "Caeruleum Sinuous Tubers",
                    Value = 1514500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            MaxOrbitalPeriod = 86400,
                            Volcanism = VolcanismRequirement.FromStrings( "major silicate vapour" ),
                            Tuber = new List<string> { "Galactic Center", "Inner S-C Arm D", "Norma Arm A" },
                        }
,
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.FromStrings( "major silicate vapour" ),
                            Region = RegionRequirement.FromStrings( "empyrean-straits" ),
                        }
                    }
                }
,
                [Genus.Tube.Species.TubeEFGH01] = new SpeciesRules
                {
                    Name = "Lindigoticum Sinuous Tubers",
                    Value = 1514500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            MaxOrbitalPeriod = 86400,
                            Volcanism = VolcanismRequirement.FromStrings( "major silicate vapour" ),
                            Tuber = new List<string> { "Inner S-C Arm A", "Inner S-C Arm C", "Hawking B", "Norma Expanse A", "Odin B" },
                        }
                    }
                }
,
                [Genus.Tube.Species.TubeEFGH02] = new SpeciesRules
                {
                    Name = "Violaceum Sinuous Tubers",
                    Value = 1514500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "High metal content body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.FromStrings( "major rocky magma", "major silicate vapour" ),
                            Tuber = new List<string> { "Arcadian Stream", "Empyrean Straits", "Norma Arm B" },
                        }
                    }
                }
,
                [Genus.Tube.Species.TubeEFGH03] = new SpeciesRules
                {
                    Name = "Viride Sinuous Tubers",
                    Value = 1514500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.FromStrings( "major rocky magma", "major silicate vapour" ),
                            Tuber = new List<string> { "Inner O-P Conflux", "Izanami", "Ryker A" },
                        }
,
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            MaxOrbitalPeriod = 86400,
                            Volcanism = VolcanismRequirement.FromStrings( "major rocky magma", "major silicate vapour" ),
                            Tuber = new List<string> { "Inner O-P Conflux", "Izanami", "Ryker A" },
                        }
                    }
                }
,
                [Genus.Tube.Species.TubeEFGH] = new SpeciesRules
                {
                    Name = "Blatteum Sinuous Tubers",
                    Value = 1514500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "High metal content body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.FromStrings( "=metallic magma volcanism", "=rocky magma volcanism", "major silicate vapour" ),
                            Tuber = new List<string> { "Arcadian Stream", "Inner Orion Spur", "Inner S-C Arm B 2", "Hawking A" },
                        }
                    }
                }
            }
        };
    }
}