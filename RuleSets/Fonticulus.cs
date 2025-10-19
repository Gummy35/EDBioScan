using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Fonticulus species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Fonticulus = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Fonticulus] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Fonticulus.Species.Fonticulus01] = new SpeciesRules
                {
                    Name = "Fonticulua Segmentatus",
                    Value = 19010800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon", "NeonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.25,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 75.0,
                            MaxPressure = 0.006,
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
,
                [Genus.Fonticulus.Species.Fonticulus02] = new SpeciesRules
                {
                    Name = "Fonticulua Campestris",
                    Value = 1000000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.027,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 150.0,
                        }
                    }
                }
,
                [Genus.Fonticulus.Species.Fonticulus03] = new SpeciesRules
                {
                    Name = "Fonticulua Upupam",
                    Value = 5727600,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "ArgonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.209,
                            MaxGravity = 0.276,
                            MinTemperature = 61.0,
                            MaxTemperature = 125.0,
                            MinPressure = 0.0175,
                        }
                    }
                }
,
                [Genus.Fonticulus.Species.Fonticulus04] = new SpeciesRules
                {
                    Name = "Fonticulua Lapida",
                    Value = 3111000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            MinGravity = 0.19,
                            MaxGravity = 0.276,
                            MinTemperature = 50.0,
                            MaxTemperature = 81.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                        }
                    }
                }
,
                [Genus.Fonticulus.Species.Fonticulus05] = new SpeciesRules
                {
                    Name = "Fonticulua Fluctus",
                    Value = 20000000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.235,
                            MaxGravity = 0.276,
                            MinTemperature = 143.0,
                            MaxTemperature = 200.0,
                            MinPressure = 0.012,
                        }
                    }
                }
,
                [Genus.Fonticulus.Species.Fonticulus06] = new SpeciesRules
                {
                    Name = "Fonticulua Digitos",
                    Value = 1804100,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.07,
                            MinTemperature = 83.0,
                            MaxTemperature = 109.0,
                            MinPressure = 0.03,
                        }
                    }
                }
            }
        };
    }
}