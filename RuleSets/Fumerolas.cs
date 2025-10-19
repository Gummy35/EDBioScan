using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Fumerolas species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Fumerolas = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Fumerolas] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Fumerolas.Species.Fumerolas01] = new SpeciesRules
                {
                    Name = "Fumerola Carbosis",
                    Value = 6284600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.168,
                            MaxGravity = 0.276,
                            MinTemperature = 57.0,
                            MaxTemperature = 150.0,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon", "methane" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.047,
                            MinTemperature = 84.0,
                            MaxTemperature = 110.0,
                            MinPressure = 0.03,
                            Volcanism = VolcanismRequirement.FromStrings( "methane magma" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.26,
                            MaxGravity = 0.276,
                            MinTemperature = 40.0,
                            MaxTemperature = 60.0,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon", "methane" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.2,
                            MaxGravity = 0.276,
                            MinTemperature = 57.0,
                            MaxTemperature = 70.0,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon", "methane" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.26,
                            MaxGravity = 0.276,
                            MinTemperature = 160.0,
                            MaxTemperature = 180.0,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.185,
                            MaxGravity = 0.276,
                            MinTemperature = 149.0,
                            MaxTemperature = 272.0,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon", "methane" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia", "ArgonRich", "CarbonDioxideRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MaxGravity = 0.276,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon" ),
                        }
                    }
                }
,
                [Genus.Fumerolas.Species.Fumerolas02] = new SpeciesRules
                {
                    Name = "Fumerola Extremus",
                    Value = 16202800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.09,
                            MinTemperature = 161.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            Volcanism = VolcanismRequirement.FromStrings( "silicate", "metallic", "rocky" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.07,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 121.0,
                            Volcanism = VolcanismRequirement.FromStrings( "silicate", "metallic", "rocky" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.127,
                            MinTemperature = 77.0,
                            MaxTemperature = 109.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "silicate", "metallic", "rocky" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body" ),
                            MinGravity = 0.07,
                            MaxGravity = 0.276,
                            MinTemperature = 54.0,
                            MaxTemperature = 210.0,
                            Volcanism = VolcanismRequirement.FromStrings( "silicate", "metallic", "rocky" ),
                        }
                    }
                }
,
                [Genus.Fumerolas.Species.Fumerolas03] = new SpeciesRules
                {
                    Name = "Fumerola Nitris",
                    Value = 7500900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 30.0,
                            MaxTemperature = 129.0,
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon", "ArgonRich", "NeonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.044,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 141.0,
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.1,
                            MinTemperature = 83.0,
                            MaxTemperature = 109.0,
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.21,
                            MaxGravity = 0.276,
                            MinTemperature = 60.0,
                            MaxTemperature = 81.0,
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MaxGravity = 0.276,
                            MinTemperature = 150.0,
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.21,
                            MaxGravity = 0.276,
                            MinTemperature = 160.0,
                            MaxTemperature = 250.0,
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
                    }
                }
,
                [Genus.Fumerolas.Species.Fumerolas04] = new SpeciesRules
                {
                    Name = "Fumerola Aquatis",
                    Value = 6284600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body", "Rocky body" ),
                            MinGravity = 0.028,
                            MaxGravity = 0.276,
                            MinTemperature = 161.0,
                            MaxTemperature = 177.0,
                            MinPressure = 0.002,
                            MaxPressure = 0.02,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon", "ArgonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.166,
                            MaxGravity = 0.276,
                            MinTemperature = 57.0,
                            MaxTemperature = 150.0,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.25,
                            MaxGravity = 0.276,
                            MinTemperature = 160.0,
                            MaxTemperature = 180.0,
                            MinPressure = 0.01,
                            MaxPressure = 0.03,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 80.0,
                            MaxTemperature = 100.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.26,
                            MaxGravity = 0.276,
                            MinTemperature = 20.0,
                            MaxTemperature = 60.0,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.195,
                            MaxGravity = 0.245,
                            MinTemperature = 56.0,
                            MaxTemperature = 80.0,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.23,
                            MaxGravity = 0.276,
                            MinTemperature = 153.0,
                            MaxTemperature = 190.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body", "Rocky body" ),
                            MinGravity = 0.18,
                            MaxGravity = 0.276,
                            MinTemperature = 150.0,
                            MaxTemperature = 270.0,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.06,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
                    }
                }
            }
        };
    }
}