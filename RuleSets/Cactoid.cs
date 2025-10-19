using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Cactoid species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Cactoid = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Cactoid] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Cactoid.Species.Cactoid01] = new SpeciesRules
                {
                    Name = "Cactoida Cortexum",
                    Value = 3667600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 180.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.025,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
                    }
                }
,
                [Genus.Cactoid.Species.Cactoid02] = new SpeciesRules
                {
                    Name = "Cactoida Lapis",
                    Value = 2483600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 160.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina" ),
                        }
                    }
                }
,
                [Genus.Cactoid.Species.Cactoid03] = new SpeciesRules
                {
                    Name = "Cactoida Vermis",
                    Value = 16202800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.265,
                            MaxGravity = 0.276,
                            MinTemperature = 160.0,
                            MaxTemperature = 210.0,
                            MaxPressure = 0.005,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
                    }
                }
,
                [Genus.Cactoid.Species.Cactoid04] = new SpeciesRules
                {
                    Name = "Cactoida Pullulanta",
                    Value = 3667600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
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
                [Genus.Cactoid.Species.Cactoid05] = new SpeciesRules
                {
                    Name = "Cactoida Peperatis",
                    Value = 2483600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 160.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            Region = RegionRequirement.FromStrings( "scutum-centaurus" ),
                        }
                    }
                }
            }
        };
    }
}