using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Ground_struct_ice species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> GroundStructIce = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.GroundStructIce] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.GroundStructIce.Species.Root] = new SpeciesRules
                {
                    Name = "Crystalline Shards",
                    Value = 1628800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "None", "Argon", "ArgonRich", "CarbonDioxide", "CarbonDioxideRich", "Helium", "Methane", "Neon", "NeonRich" ),
                            MaxGravity = 2.0,
                            MaxTemperature = 273.0,
                            Star = StarRequirement.FromStrings( "A", "F", "G", "K", "MS", "S" ),
                            Distance = 12000.0,
                            Bodies = SpecialBodyRequirement.FromStrings( "Earthlike body", "Ammonia world", "Water world", "Gas giant with water based life", "Gas giant with ammonia based life", "Water giant" ),
                            Region = RegionRequirement.FromStrings( "exterior" ),
                        }
                    }
                }
            }
        };
    }
}