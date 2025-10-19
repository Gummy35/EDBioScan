using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Osseus species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Osseus = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Osseus] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Osseus.Species.Osseus01] = new SpeciesRules
                {
                    Name = "Osseus Fractus",
                    Value = 4027800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 180.0,
                            MaxTemperature = 190.0,
                            MinPressure = 0.025,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "!perseus" ),
                        }
                    }
                }
,
                [Genus.Osseus.Species.Osseus02] = new SpeciesRules
                {
                    Name = "Osseus Discus",
                    Value = 12934900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.088,
                            MinTemperature = 161.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body" ),
                            MinGravity = 0.2,
                            MaxGravity = 0.276,
                            MinTemperature = 65.0,
                            MaxTemperature = 120.0,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.127,
                            MinTemperature = 80.0,
                            MaxTemperature = 110.0,
                            MinPressure = 0.012,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.055,
                        }
                    }
                }
,
                [Genus.Osseus.Species.Osseus03] = new SpeciesRules
                {
                    Name = "Osseus Spiralis",
                    Value = 2404700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 160.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                        }
                    }
                }
,
                [Genus.Osseus.Species.Osseus04] = new SpeciesRules
                {
                    Name = "Osseus Pumice",
                    Value = 3156300,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.059,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 135.0,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body" ),
                            MinGravity = 0.059,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 135.0,
                            Volcanism = VolcanismRequirement.FromStrings( "water", "geysers" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "ArgonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body" ),
                            MinGravity = 0.035,
                            MaxGravity = 0.276,
                            MinTemperature = 60.0,
                            MaxTemperature = 80.5,
                            MinPressure = 0.03,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.033,
                            MaxGravity = 0.276,
                            MinTemperature = 67.0,
                            MaxTemperature = 109.0,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.05,
                            MaxGravity = 0.276,
                            MinTemperature = 42.0,
                            MaxTemperature = 70.1,
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
,
                [Genus.Osseus.Species.Osseus05] = new SpeciesRules
                {
                    Name = "Osseus Cornibus",
                    Value = 1483000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.0405,
                            MaxGravity = 0.276,
                            MinTemperature = 180.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.025,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "perseus" ),
                        }
                    }
                }
,
                [Genus.Osseus.Species.Osseus06] = new SpeciesRules
                {
                    Name = "Osseus Pellebantus",
                    Value = 9739000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.0405,
                            MaxGravity = 0.276,
                            MinTemperature = 191.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.057,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "!perseus" ),
                        }
                    }
                }
            }
        };
    }
}