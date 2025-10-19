using ExoScan.Enums;
using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Electricae species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Electricae = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Electricae] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Electricae.Species.Electricae01] = new SpeciesRules
                {
                    Name = "Electricae Pluma",
                    Value = 6284600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon", "ArgonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 150.0,
                            ParentStar = StarRequirement.FromStrings( "A", "N", "D", "H", "AeBe" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon", "NeonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.26,
                            MaxGravity = 0.276,
                            MinTemperature = 20.0,
                            MaxTemperature = 70.0,
                            MaxPressure = 0.005,
                            ParentStar = StarRequirement.FromStrings( "A", "N", "D", "H", "AeBe" ),
                        }
                    }
                }
,
                [Genus.Electricae.Species.Electricae02] = new SpeciesRules
                {
                    Name = "Electricae Radialem",
                    Value = 6284600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon", "ArgonRich" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 150.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            Nebula = NebulaType.All,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon", "NeonRich" ),
                            MinGravity = 0.026,
                            MaxGravity = 0.276,
                            MinTemperature = 20.0,
                            MaxTemperature = 70.0,
                            MaxPressure = 0.005,
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            Nebula = NebulaType.All,
                        }
                    }
                }
            }
        };
    }
}