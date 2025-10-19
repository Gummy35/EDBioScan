using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Stratum_04 species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Stratum = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Aranaemus] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Stratum.Species.Stratum04] = new SpeciesRules
                {
                    Name = "Stratum Aranaemus",
                    Value = 2448900,
                    Rulesets = new List<Ruleset>
                    {
                    }
                }
            }
,
            [GenusEnum.Stratum] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Stratum.Species.Stratum01] = new SpeciesRules
                {
                    Name = "Stratum Excutitus",
                    Value = 2448900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.48,
                            MinTemperature = 165.0,
                            MaxTemperature = 190.0,
                            MinPressure = 0.0035,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.27,
                            MaxGravity = 0.4,
                            MinTemperature = 165.0,
                            MaxTemperature = 190.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
                    }
                }
,
                [Genus.Stratum.Species.Stratum02] = new SpeciesRules
                {
                    Name = "Stratum Paleas",
                    Value = 1362000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.35,
                            MinTemperature = 165.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.585,
                            MinTemperature = 165.0,
                            MaxTemperature = 395.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxideRich" ),
                            MinGravity = 0.43,
                            MaxGravity = 0.585,
                            MinTemperature = 185.0,
                            MaxTemperature = 260.0,
                            MinPressure = 0.015,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.056,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.056,
                            MinPressure = 0.065,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            MinGravity = 0.39,
                            MaxGravity = 0.59,
                            MinTemperature = 165.0,
                            MaxTemperature = 250.0,
                            MinPressure = 0.022,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                        }
                    }
                }
,
                [Genus.Stratum.Species.Stratum03] = new SpeciesRules
                {
                    Name = "Stratum Laminamus",
                    Value = 2788300,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.34,
                            MinTemperature = 165.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
                    }
                }
,
                [Genus.Stratum.Species.Stratum04] = new SpeciesRules
                {
                    Name = "Stratum Araneamus",
                    Value = 2448900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.26,
                            MaxGravity = 0.57,
                            MinTemperature = 165.0,
                            MaxTemperature = 373.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                        }
                    }
                }
,
                [Genus.Stratum.Species.Stratum05] = new SpeciesRules
                {
                    Name = "Stratum Limaxus",
                    Value = 1362000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.03,
                            MaxGravity = 0.4,
                            MinTemperature = 165.0,
                            MaxTemperature = 190.0,
                            MinPressure = 0.05,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "scutum-centaurus-core" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.27,
                            MaxGravity = 0.4,
                            MinTemperature = 165.0,
                            MaxTemperature = 190.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Region = RegionRequirement.FromStrings( "scutum-centaurus-core" ),
                        }
                    }
                }
,
                [Genus.Stratum.Species.Stratum06] = new SpeciesRules
                {
                    Name = "Stratum Cucumisis",
                    Value = 16202800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.6,
                            MinTemperature = 191.0,
                            MaxTemperature = 371.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxideRich" ),
                            MinGravity = 0.44,
                            MaxGravity = 0.56,
                            MinTemperature = 210.0,
                            MaxTemperature = 246.0,
                            MinPressure = 0.01,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            MinGravity = 0.4,
                            MaxGravity = 0.6,
                            MinTemperature = 200.0,
                            MaxTemperature = 250.0,
                            MinPressure = 0.01,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Region = RegionRequirement.FromStrings( "sagittarius-carina" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.26,
                            MaxGravity = 0.55,
                            MinTemperature = 191.0,
                            MaxTemperature = 373.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Region = RegionRequirement.FromStrings( "sagittarius-carina" ),
                        }
                    }
                }
,
                [Genus.Stratum.Species.Stratum07] = new SpeciesRules
                {
                    Name = "Stratum Tectonicas",
                    Value = 19010800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            MinGravity = 0.045,
                            MaxGravity = 0.38,
                            MinTemperature = 165.0,
                            MaxTemperature = 177.0,
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon", "ArgonRich" ),
                            MinGravity = 0.485,
                            MaxGravity = 0.54,
                            MinTemperature = 167.0,
                            MaxTemperature = 199.0,
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.045,
                            MaxGravity = 0.61,
                            MinTemperature = 165.0,
                            MaxTemperature = 430.0,
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxideRich" ),
                            MinGravity = 0.035,
                            MaxGravity = 0.61,
                            MinTemperature = 165.0,
                            MaxTemperature = 260.0,
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            MinGravity = 0.4,
                            MaxGravity = 0.52,
                            MinTemperature = 165.0,
                            MaxTemperature = 246.0,
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.29,
                            MaxGravity = 0.62,
                            MinTemperature = 165.0,
                            MaxTemperature = 450.0,
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            MinGravity = 0.045,
                            MaxGravity = 0.063,
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
,
                [Genus.Stratum.Species.Stratum08] = new SpeciesRules
                {
                    Name = "Stratum Frigus",
                    Value = 2637500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.043,
                            MaxGravity = 0.54,
                            MinTemperature = 191.0,
                            MaxTemperature = 365.0,
                            MinPressure = 0.001,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "perseus-core" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxideRich" ),
                            MinGravity = 0.45,
                            MaxGravity = 0.56,
                            MinTemperature = 200.0,
                            MaxTemperature = 250.0,
                            MinPressure = 0.01,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "perseus-core" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.29,
                            MaxGravity = 0.52,
                            MinTemperature = 191.0,
                            MaxTemperature = 369.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Region = RegionRequirement.FromStrings( "perseus-core" ),
                        }
                    }
                }
            }
        };
    }
}