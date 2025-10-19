using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Conchas species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Conchas = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Conchas] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Conchas.Species.Conchas01] = new SpeciesRules
                {
                    Name = "Concha Renibus",
                    Value = 4572400,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.045,
                            MinTemperature = 176.0,
                            MaxTemperature = 177.0,
                            Volcanism = VolcanismRequirement.FromStrings( "silicate", "metallic" ),
                        }
,
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
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.15,
                            MinTemperature = 78.0,
                            MaxTemperature = 100.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "silicate", "metallic" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.65,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.65,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
                    }
                }
,
                [Genus.Conchas.Species.Conchas02] = new SpeciesRules
                {
                    Name = "Concha Aureolas",
                    Value = 7774700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 152.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                        }
                    }
                }
,
                [Genus.Conchas.Species.Conchas03] = new SpeciesRules
                {
                    Name = "Concha Labiata",
                    Value = 2352400,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 150.0,
                            MaxTemperature = 200.0,
                            MinPressure = 0.002,
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
,
                [Genus.Conchas.Species.Conchas04] = new SpeciesRules
                {
                    Name = "Concha Biconcavis",
                    Value = 16777215,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.053,
                            MaxGravity = 0.275,
                            MinTemperature = 42.0,
                            MaxTemperature = 52.0,
                            MaxPressure = 0.0047,
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
            }
        };
    }
}