using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Aleoida = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Aleoids] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Aleoids.Species.Aleoids01] = new SpeciesRules
                {
                    Name = "Aleoida Arcus",
                    Value = 7252500,
                    Rulesets = new List<Ruleset>
                {
                    new Ruleset
                    {
                        Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                        MinGravity = 0.04,
                        MaxGravity = 0.276,
                        MinTemperature = 175.0,
                        MaxTemperature = 180.0,
                        MinPressure = 0.0161,
                        BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                        Volcanism = VolcanismRequirement.None
                    }
                }
                },
                [Genus.Aleoids.Species.Aleoids02] = new SpeciesRules
                {
                    Name = "Aleoida Coronamus",
                    Value = 6284600,
                    Rulesets = new List<Ruleset>
                {
                    new Ruleset
                    {
                        Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                        MinGravity = 0.04,
                        MaxGravity = 0.276,
                        MinTemperature = 180.0,
                        MaxTemperature = 190.0,
                        MinPressure = 0.025,
                        BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                        Volcanism = VolcanismRequirement.None
                    }
                }
                },
                [Genus.Aleoids.Species.Aleoids03] = new SpeciesRules
                {
                    Name = "Aleoida Spica",
                    Value = 3385200,
                    Rulesets = new List<Ruleset>
                {
                    new Ruleset
                    {
                        Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                        MinGravity = 0.04,
                        MaxGravity = 0.276,
                        MinTemperature = 170.0,
                        MaxTemperature = 177.0,
                        MaxPressure = 0.0135,
                        BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                        Region = RegionRequirement.FromStrings( "outer", "perseus", "scutum-centaurus" )
                    }
                }
                },
                [Genus.Aleoids.Species.Aleoids04] = new SpeciesRules
                {
                    Name = "Aleoida Laminiae",
                    Value = 3385200,
                    Rulesets = new List<Ruleset>
                {
                    new Ruleset
                    {
                        Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                        MinGravity = 0.04,
                        MaxGravity = 0.276,
                        MinTemperature = 152.0,
                        MaxTemperature = 177.0,
                        MaxPressure = 0.0135,
                        BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                        Region = RegionRequirement.FromStrings( "orion-cygnus", "sagittarius-carina" )
                    }
                }
                },
                [Genus.Aleoids.Species.Aleoids05] = new SpeciesRules
                {
                    Name = "Aleoida Gravis",
                    Value = 12934900,
                    Rulesets = new List<Ruleset>
                {
                    new Ruleset
                    {
                        Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                        MinGravity = 0.04,
                        MaxGravity = 0.276,
                        MinTemperature = 190.0,
                        MaxTemperature = 197.0,
                        MinPressure = 0.054,
                        BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                        Volcanism = VolcanismRequirement.None
                    }
                }
                }
            }
        };
    }
}
