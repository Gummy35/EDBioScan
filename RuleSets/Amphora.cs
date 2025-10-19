using ExoScan.Enums;
using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Aleoids species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Amphora = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Cone] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Cone.Species.Root] = new SpeciesRules
                {
                    Name = "Bark Mound",
                    Value = 1471900,
                    Rulesets = new List<Ruleset>
                {
                    new Ruleset
                    {
                        Volcanism = VolcanismRequirement.Any,
                        Nebula = NebulaType.Large,
                        Region = RegionRequirement.FromStrings( "!center" )
                    }
                }
                }
            },
            [GenusEnum.Vents] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Vents.Species.Root] = new SpeciesRules
                {
                    Name = "Amphora Plant",
                    Value = 1628800,
                    Rulesets = new List<Ruleset>
                {
                    new Ruleset
                    {
                        BodyType = BodyTypeRequirement.FromStrings( "Metal rich body" ),
                        Atmosphere = AtmosphereRequirement.FromStrings( "None" ),
                        Star = StarRequirement.FromStrings("A"),
                        MinTemperature = 1000.0,
                        MaxTemperature = 1750.0,
                        Volcanism = VolcanismRequirement.FromStrings( "metallic", "rocky", "silicate" ),
                        Bodies = SpecialBodyRequirement.FromStrings( "Earthlike body", "Gas giant with water based life", "Water giant" ),
                        Region = RegionRequirement.FromStrings( "amphora" )
                    }
                }
                }
            }
        };
    }
}
