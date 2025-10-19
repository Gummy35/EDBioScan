using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Tussocks species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Tussocks = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Tussocks] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Tussocks.Species.Tussocks01] = new SpeciesRules
                {
                    Name = "Tussock Pennata",
                    Value = 5853800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.09,
                            MinTemperature = 146.0,
                            MaxTemperature = 154.0,
                            MinPressure = 0.00289,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina-core-9", "perseus-core", "orion-cygnus-core" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks02] = new SpeciesRules
                {
                    Name = "Tussock Ventusa",
                    Value = 3227700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.13,
                            MinTemperature = 155.0,
                            MaxTemperature = 160.0,
                            MinPressure = 0.00289,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina-core-9", "perseus-core", "orion-cygnus-core" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks03] = new SpeciesRules
                {
                    Name = "Tussock Ignis",
                    Value = 1849000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.2,
                            MinTemperature = 161.0,
                            MaxTemperature = 170.0,
                            MinPressure = 0.00289,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina-core-9", "perseus-core", "orion-cygnus-core" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks04] = new SpeciesRules
                {
                    Name = "Tussock Cultro",
                    Value = 1766600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 152.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks05] = new SpeciesRules
                {
                    Name = "Tussock Catena",
                    Value = 1766600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 152.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            Region = RegionRequirement.FromStrings( "scutum-centaurus-core" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks06] = new SpeciesRules
                {
                    Name = "Tussock Pennatis",
                    Value = 1000000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 147.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.00289,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "outer" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks07] = new SpeciesRules
                {
                    Name = "Tussock Serrati",
                    Value = 4447100,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.042,
                            MaxGravity = 0.23,
                            MinTemperature = 171.0,
                            MaxTemperature = 174.0,
                            MinPressure = 0.01,
                            MaxPressure = 0.071,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina-core-9", "perseus-core", "orion-cygnus-core" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks08] = new SpeciesRules
                {
                    Name = "Tussock Albata",
                    Value = 3252500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.042,
                            MaxGravity = 0.276,
                            MinTemperature = 175.0,
                            MaxTemperature = 180.0,
                            MinPressure = 0.016,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina-core-9", "perseus-core", "orion-cygnus-core" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks09] = new SpeciesRules
                {
                    Name = "Tussock Propagito",
                    Value = 1000000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 145.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.00289,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "scutum-centaurus" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks10] = new SpeciesRules
                {
                    Name = "Tussock Divisa",
                    Value = 1766600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.042,
                            MaxGravity = 0.276,
                            MinTemperature = 152.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            Region = RegionRequirement.FromStrings( "perseus-core" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks11] = new SpeciesRules
                {
                    Name = "Tussock Caputus",
                    Value = 3472400,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.041,
                            MaxGravity = 0.27,
                            MinTemperature = 181.0,
                            MaxTemperature = 190.0,
                            MinPressure = 0.0275,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina-core-9", "perseus-core", "orion-cygnus-core" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks12] = new SpeciesRules
                {
                    Name = "Tussock Triticum",
                    Value = 7774700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 191.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.058,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina-core-9", "perseus-core", "orion-cygnus-core" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks13] = new SpeciesRules
                {
                    Name = "Tussock Stigmasis",
                    Value = 19010800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 132.0,
                            MaxTemperature = 180.0,
                            MaxPressure = 0.01,
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks14] = new SpeciesRules
                {
                    Name = "Tussock Virgam",
                    Value = 14313700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.065,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.065,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
                    }
                }
,
                [Genus.Tussocks.Species.Tussocks15] = new SpeciesRules
                {
                    Name = "Tussock Capillum",
                    Value = 7025800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            MinGravity = 0.22,
                            MaxGravity = 0.276,
                            MinTemperature = 80.0,
                            MaxTemperature = 129.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            MinGravity = 0.033,
                            MaxGravity = 0.276,
                            MinTemperature = 80.0,
                            MaxTemperature = 110.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body" ),
                        }
                    }
                }
            }
        };
    }
}