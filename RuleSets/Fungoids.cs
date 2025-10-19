using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Fungoids species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Fungoids = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Fungoids] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Fungoids.Species.Fungoids01] = new SpeciesRules
                {
                    Name = "Fungoida Setisis",
                    Value = 1670100,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 152.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body" ),
                            MinGravity = 0.033,
                            MaxGravity = 0.276,
                            MinTemperature = 68.0,
                            MaxTemperature = 109.0,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.033,
                            MaxGravity = 0.276,
                            MinTemperature = 67.0,
                            MaxTemperature = 109.0,
                        }
                    }
                }
,
                [Genus.Fungoids.Species.Fungoids02] = new SpeciesRules
                {
                    Name = "Fungoida Stabitis",
                    Value = 2680300,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.045,
                            MinTemperature = 172.0,
                            MaxTemperature = 177.0,
                            Volcanism = VolcanismRequirement.FromStrings( "silicate" ),
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body" ),
                            MinGravity = 0.2,
                            MaxGravity = 0.23,
                            MinTemperature = 60.0,
                            MaxTemperature = 90.0,
                            Volcanism = VolcanismRequirement.FromStrings( "silicate", "rocky" ),
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "ArgonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.3,
                            MaxGravity = 0.5,
                            MinTemperature = 60.0,
                            MaxTemperature = 90.0,
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.0405,
                            MaxGravity = 0.27,
                            MinTemperature = 180.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.025,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.043,
                            MaxGravity = 0.126,
                            MinTemperature = 78.5,
                            MaxTemperature = 109.0,
                            MinPressure = 0.012,
                            Volcanism = VolcanismRequirement.FromStrings( "major silicate" ),
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.039,
                            MaxGravity = 0.064,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
                    }
                }
,
                [Genus.Fungoids.Species.Fungoids03] = new SpeciesRules
                {
                    Name = "Fungoida Bullarum",
                    Value = 3703200,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            MinGravity = 0.058,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 129.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            MinGravity = 0.155,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 70.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
,
                [Genus.Fungoids.Species.Fungoids04] = new SpeciesRules
                {
                    Name = "Fungoida Gelata",
                    Value = 3330300,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body" ),
                            MinGravity = 0.041,
                            MaxGravity = 0.276,
                            MinTemperature = 160.0,
                            MaxTemperature = 180.0,
                            MaxPressure = 0.0135,
                            Volcanism = VolcanismRequirement.FromStrings( "major silicate" ),
                            Region = RegionRequirement.FromStrings( "!orion-cygnus-core" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body" ),
                            MinGravity = 0.042,
                            MaxGravity = 0.071,
                            MinTemperature = 160.0,
                            MaxTemperature = 180.0,
                            MaxPressure = 0.0135,
                            Volcanism = VolcanismRequirement.FromStrings( "major silicate" ),
                            Region = RegionRequirement.FromStrings( "!orion-cygnus-core" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinGravity = 0.042,
                            MaxGravity = 0.071,
                            MinTemperature = 160.0,
                            MaxTemperature = 180.0,
                            MaxPressure = 0.0135,
                            Volcanism = VolcanismRequirement.FromStrings( "major rocky" ),
                            Region = RegionRequirement.FromStrings( "!orion-cygnus-core" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.041,
                            MaxGravity = 0.276,
                            MinTemperature = 180.0,
                            MaxTemperature = 200.0,
                            MinPressure = 0.025,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "!orion-cygnus-core" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.044,
                            MaxGravity = 0.125,
                            MinTemperature = 80.0,
                            MaxTemperature = 110.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "major silicate", "major metallic" ),
                            Region = RegionRequirement.FromStrings( "!orion-cygnus-core" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.039,
                            MaxGravity = 0.063,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "!orion-cygnus-core" ),
                        }
                    }
                }
            }
        };
    }
}