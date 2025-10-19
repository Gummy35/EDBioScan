using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Sphere species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Anemone = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Sphere] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Sphere.Species.Root] = new SpeciesRules
                {
                    Name = "Luteolum Anemone",
                    Value = 1499900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            MinGravity = 0.044,
                            MaxGravity = 1.28,
                            MaxTemperature = 440.0,
                            MinTemperature = 200.0,
                            Volcanism = VolcanismRequirement.FromStrings( "metallic", "silicate", "rocky", "water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Star = StarRequirement.FromTuples(("B", "IV"), ("B", "V") ),
                            Region = RegionRequirement.FromStrings( "anemone-a" ),
                        }
                    }
                }
,
                [Genus.Sphere.Species.SphereABCD01] = new SpeciesRules
                {
                    Name = "Croceum Anemone",
                    Value = 1499900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            MinGravity = 0.047,
                            MaxGravity = 0.37,
                            MaxTemperature = 440.0,
                            MinTemperature = 200.0,
                            Volcanism = VolcanismRequirement.FromStrings( "silicate", "rocky", "metallic" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Star = StarRequirement.FromTuples(("B", "V"), ("B", "VI"), ("A", "III") ),
                            Region = RegionRequirement.FromStrings( "anemone-a" ),
                        }
                    }
                }
,
                [Genus.Sphere.Species.SphereABCD02] = new SpeciesRules
                {
                    Name = "Puniceum Anemone",
                    Value = 1499900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            MinGravity = 0.17,
                            MaxGravity = 2.52,
                            MaxTemperature = 800.0,
                            MinTemperature = 65.0,
                            Volcanism = VolcanismRequirement.None,
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            Star = StarRequirement.FromStrings( "O" ),
                            Region = RegionRequirement.FromStrings( "anemone-a" ),
                        }
,
                        new Ruleset
                        {
                            MinGravity = 0.17,
                            MaxGravity = 2.52,
                            MaxTemperature = 800.0,
                            MinTemperature = 65.0,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon dioxide geysers" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            Star = StarRequirement.FromStrings( "O" ),
                            Region = RegionRequirement.FromStrings( "anemone-a" ),
                        }
                    }
                }
,
                [Genus.Sphere.Species.SphereABCD03] = new SpeciesRules
                {
                    Name = "Roseum Anemone",
                    Value = 1499900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            MinGravity = 0.045,
                            MaxGravity = 0.37,
                            MaxTemperature = 440.0,
                            MinTemperature = 200.0,
                            Volcanism = VolcanismRequirement.FromStrings( "silicate", "rocky", "metallic" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            Star = StarRequirement.FromTuples(("B", "I"), ("B", "II"), ("B", "III"), ("B", "IV") ),
                            Region = RegionRequirement.FromStrings( "anemone-a" ),
                        }
                    }
                }
,
                [Genus.Sphere.Species.SphereEFGH01] = new SpeciesRules
                {
                    Name = "Rubeum Bioluminescent Anemone",
                    Value = 1499900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            MinGravity = 0.036,
                            MaxGravity = 4.61,
                            MinTemperature = 160.0,
                            MaxTemperature = 1800.0,
                            Volcanism = VolcanismRequirement.Any,
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "High metal content body" ),
                            Star = StarRequirement.FromTuples(("B", "VI"), ("A", "I"), ("A", "II"), ("A", "III"), ("N", null) ),
                        }
                    }
                }
,
                [Genus.Sphere.Species.SphereEFGH02] = new SpeciesRules
                {
                    Name = "Prasinum Bioluminescent Anemone",
                    Value = 1499900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            MinGravity = 0.036,
                            MinTemperature = 110.0,
                            MaxTemperature = 3050.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "Rocky body", "High metal content body" ),
                            Star = StarRequirement.FromStrings( "O" ),
                        }
                    }
                }
,
                [Genus.Sphere.Species.SphereEFGH03] = new SpeciesRules
                {
                    Name = "Roseum Bioluminescent Anemone",
                    Value = 1499900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            MinGravity = 0.036,
                            MaxGravity = 4.61,
                            MinTemperature = 400.0,
                            Volcanism = VolcanismRequirement.Any,
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "High metal content body" ),
                            Star = StarRequirement.FromTuples(("B", "I"), ("B", "II"), ("B", "III") ),
                        }
                    }
                }
,
                [Genus.Sphere.Species.SphereEFGH] = new SpeciesRules
                {
                    Name = "Blatteum Bioluminescent Anemone",
                    Value = 1499900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            MinTemperature = 220.0,
                            Volcanism = VolcanismRequirement.Any,
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "High metal content body" ),
                            Star = StarRequirement.FromTuples(("B", "IV"), ("B", "V") ),
                            Region = RegionRequirement.FromStrings( "anemone-a" ),
                        }
                    }
                }
            }
        };
    }
}