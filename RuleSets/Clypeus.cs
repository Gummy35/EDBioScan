using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Clypeus species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Clypeus = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Clypeus] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Clypeus.Species.Clypeus01] = new SpeciesRules
                {
                    Name = "Clypeus Lacrimam",
                    Value = 8418000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 190.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.054,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
                    }
                }
,
                [Genus.Clypeus.Species.Clypeus02] = new SpeciesRules
                {
                    Name = "Clypeus Margaritus",
                    Value = 11873200,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 190.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.054,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
,
                [Genus.Clypeus.Species.Clypeus03] = new SpeciesRules
                {
                    Name = "Clypeus Speculumi",
                    Value = 16202800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 190.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.055,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                            Distance = 2000.0,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.None,
                            Distance = 2000.0,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                            Distance = 2000.0,
                        }
                    }
                }
            }
        };
    }
}