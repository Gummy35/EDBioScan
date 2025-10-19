using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Tubus species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Tubus = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Tubus] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Tubus.Species.Tubus01] = new SpeciesRules
                {
                    Name = "Tubus Conifer",
                    Value = 2415500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.041,
                            MaxGravity = 0.153,
                            MinTemperature = 160.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.003,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "perseus" ),
                        }
                    }
                }
,
                [Genus.Tubus.Species.Tubus02] = new SpeciesRules
                {
                    Name = "Tubus Sororibus",
                    Value = 5727600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinGravity = 0.045,
                            MaxGravity = 0.152,
                            MinTemperature = 160.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinGravity = 0.045,
                            MaxGravity = 0.152,
                            MinTemperature = 160.0,
                            MaxTemperature = 195.0,
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
,
                [Genus.Tubus.Species.Tubus03] = new SpeciesRules
                {
                    Name = "Tubus Cavas",
                    Value = 11873200,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.152,
                            MinTemperature = 160.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.003,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "scutum-centaurus" ),
                        }
                    }
                }
,
                [Genus.Tubus.Species.Tubus04] = new SpeciesRules
                {
                    Name = "Tubus Rosarium",
                    Value = 2637500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.153,
                            MinTemperature = 160.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                        }
                    }
                }
,
                [Genus.Tubus.Species.Tubus05] = new SpeciesRules
                {
                    Name = "Tubus Compagibus",
                    Value = 7774700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.153,
                            MinTemperature = 160.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.003,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "sagittarius-carina" ),
                        }
                    }
                }
            }
        };
    }
}