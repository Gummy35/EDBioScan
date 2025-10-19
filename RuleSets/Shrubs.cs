using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Shrubs species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Shrubs = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Shrubs] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Shrubs.Species.Shrubs01] = new SpeciesRules
                {
                    Name = "Frutexa Flabellum",
                    Value = 1808900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 152.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            Region = RegionRequirement.FromStrings( "!scutum-centaurus" ),
                        }
                    }
                }
,
                [Genus.Shrubs.Species.Shrubs02] = new SpeciesRules
                {
                    Name = "Frutexa Acus",
                    Value = 7774700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.237,
                            MinTemperature = 146.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.0029,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "orion-cygnus" ),
                        }
                    }
                }
,
                [Genus.Shrubs.Species.Shrubs03] = new SpeciesRules
                {
                    Name = "Frutexa Metallicum",
                    Value = 1632500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 152.0,
                            MaxTemperature = 176.0,
                            MaxPressure = 0.01,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 146.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.002,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinGravity = 0.05,
                            MaxGravity = 0.1,
                            MinTemperature = 100.0,
                            MaxTemperature = 300.0,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.07,
                            MaxTemperature = 400.0,
                            MaxPressure = 0.07,
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
,
                [Genus.Shrubs.Species.Shrubs04] = new SpeciesRules
                {
                    Name = "Frutexa Flammasis",
                    Value = 10326000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 152.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                            Region = RegionRequirement.FromStrings( "scutum-centaurus" ),
                        }
                    }
                }
,
                [Genus.Shrubs.Species.Shrubs05] = new SpeciesRules
                {
                    Name = "Frutexa Fera",
                    Value = 1632500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 146.0,
                            MaxTemperature = 197.0,
                            MinPressure = 0.003,
                            Volcanism = VolcanismRequirement.None,
                            Region = RegionRequirement.FromStrings( "outer" ),
                        }
                    }
                }
,
                [Genus.Shrubs.Species.Shrubs06] = new SpeciesRules
                {
                    Name = "Frutexa Sponsae",
                    Value = 5988000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.056,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.056,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
                    }
                }
,
                [Genus.Shrubs.Species.Shrubs07] = new SpeciesRules
                {
                    Name = "Frutexa Collum",
                    Value = 1639800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.276,
                            MinTemperature = 132.0,
                            MaxTemperature = 215.0,
                            MaxPressure = 0.004,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "High metal content body" ),
                            MinGravity = 0.265,
                            MaxGravity = 0.276,
                            MinTemperature = 132.0,
                            MaxTemperature = 135.0,
                            MaxPressure = 0.004,
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
            }
        };
    }
}