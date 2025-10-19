using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Brancae species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Brancae = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Brancae] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Brancae.Species.Seed] = new SpeciesRules
                {
                    Name = "Roseum Brain Tree",
                    Value = 1593700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            MinTemperature = 200.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.Any,
                            Guardian = true,
                            Region = RegionRequirement.FromStrings( "brain-tree" ),
                        }
                    }
                }
,
                [Genus.Brancae.Species.SeedABCD01] = new SpeciesRules
                {
                    Name = "Gypseeum Brain Tree",
                    Value = 1593700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinTemperature = 200.0,
                            MaxTemperature = 400.0,
                            MaxGravity = 0.42,
                            Volcanism = VolcanismRequirement.FromStrings( "metallic", "rocky", "silicate", "water" ),
                            Guardian = true,
                            Region = RegionRequirement.FromStrings( "brain-tree" ),
                            Bodies = SpecialBodyRequirement.FromStrings( "Earthlike body", "Gas giant with water based life", "Water giant" ),
                        }
                    }
                }
,
                [Genus.Brancae.Species.SeedABCD02] = new SpeciesRules
                {
                    Name = "Ostrinum Brain Tree",
                    Value = 1593700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "Rocky body", "High metal content body" ),
                            Volcanism = VolcanismRequirement.FromStrings( "metallic", "rocky", "silicate" ),
                            Guardian = true,
                            Region = RegionRequirement.FromStrings( "brain-tree" ),
                        }
                    }
                }
,
                [Genus.Brancae.Species.SeedABCD03] = new SpeciesRules
                {
                    Name = "Viride Brain Tree",
                    Value = 1593700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body" ),
                            MinTemperature = 100.0,
                            MaxTemperature = 270.0,
                            MaxGravity = 0.4,
                            Volcanism = VolcanismRequirement.Any,
                            Guardian = true,
                            Region = RegionRequirement.FromStrings( "brain-tree" ),
                            Bodies = SpecialBodyRequirement.FromStrings( "Earthlike body", "Gas giant with water based life", "Water giant" ),
                        }
                    }
                }
,
                [Genus.Brancae.Species.SeedEFGH01] = new SpeciesRules
                {
                    Name = "Aureum Brain Tree",
                    Value = 1593700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "High metal content body" ),
                            MinTemperature = 300.0,
                            MaxTemperature = 500.0,
                            MaxGravity = 2.9,
                            Volcanism = VolcanismRequirement.FromStrings( "metallic", "rocky", "silicate" ),
                            Guardian = true,
                            Region = RegionRequirement.FromStrings( "brain-tree" ),
                        }
                    }
                }
,
                [Genus.Brancae.Species.SeedEFGH02] = new SpeciesRules
                {
                    Name = "Puniceum Brain Tree",
                    Value = 1593700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Metal rich body", "High metal content body" ),
                            Volcanism = VolcanismRequirement.Any,
                            Guardian = true,
                            Region = RegionRequirement.FromStrings( "brain-tree" ),
                            Bodies = SpecialBodyRequirement.FromStrings( "Earthlike body", "Gas giant with water based life", "Water giant" ),
                        }
                    }
                }
,
                [Genus.Brancae.Species.SeedEFGH03] = new SpeciesRules
                {
                    Name = "Lindigoticum Brain Tree",
                    Value = 1593700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinTemperature = 300.0,
                            MaxTemperature = 500.0,
                            MaxGravity = 2.7,
                            Volcanism = VolcanismRequirement.FromStrings( "rocky", "silicate", "metallic" ),
                            Guardian = true,
                            Region = RegionRequirement.FromStrings( "brain-tree" ),
                            Bodies = SpecialBodyRequirement.FromStrings( "Earthlike body", "Gas giant with water based life", "Water giant" ),
                        }
                    }
                }
,
                [Genus.Brancae.Species.SeedEFGH] = new SpeciesRules
                {
                    Name = "Lividum Brain Tree",
                    Value = 1593700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinTemperature = 300.0,
                            MaxTemperature = 500.0,
                            MaxGravity = 0.5,
                            Volcanism = VolcanismRequirement.FromStrings( "metallic", "rocky", "silicate", "water" ),
                            Guardian = true,
                            Region = RegionRequirement.FromStrings( "brain-tree" ),
                        }
                    }
                }
            }
        };
    }
}