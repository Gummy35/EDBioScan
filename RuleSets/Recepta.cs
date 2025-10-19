using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Recepta species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Recepta = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Recepta] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Recepta.Species.Recepta01] = new SpeciesRules
                {
                    Name = "Recepta Umbrux",
                    Value = 12934900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 151.0,
                            MaxTemperature = 200.0,
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.23,
                            MaxGravity = 0.276,
                            MinTemperature = 154.0,
                            MaxTemperature = 175.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.None,
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.23,
                            MaxGravity = 0.276,
                            MinTemperature = 154.0,
                            MaxTemperature = 175.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 132.0,
                            MaxTemperature = 273.0,
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
                    }
                }
,
                [Genus.Recepta.Species.Recepta02] = new SpeciesRules
                {
                    Name = "Recepta Deltahedronix",
                    Value = 16202800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 150.0,
                            MaxTemperature = 195.0,
                            Volcanism = VolcanismRequirement.None,
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 150.0,
                            MaxTemperature = 195.0,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 132.0,
                            MaxTemperature = 272.0,
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
                    }
                }
,
                [Genus.Recepta.Species.Recepta03] = new SpeciesRules
                {
                    Name = "Recepta Conditivus",
                    Value = 14313700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide", "CarbonDioxideRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 150.0,
                            MaxTemperature = 195.0,
                            Volcanism = VolcanismRequirement.None,
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.23,
                            MaxGravity = 0.276,
                            MinTemperature = 154.0,
                            MaxTemperature = 175.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.None,
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.23,
                            MaxGravity = 0.276,
                            MinTemperature = 154.0,
                            MaxTemperature = 175.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 132.0,
                            MaxTemperature = 275.0,
                            AtmosphereComponent = new Dictionary<string, double> { { "SulphurDioxide", 1.05 } },
                        }
                    }
                }
            }
        };
    }
}