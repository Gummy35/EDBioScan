using ExoScan.Requirements;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    public partial class Species
    {
        /// <summary>
        /// Bacterial species catalog
        /// </summary>
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Bacterial = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>
        {
            [GenusEnum.Bacterial] = new Dictionary<ushort, SpeciesRules>
            {
                [Genus.Bacterial.Species.Bacterial01] = new SpeciesRules
                {
                    Name = "Bacterium Aurasus",
                    Value = 1000000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body", "Rocky ice body" ),
                            MinGravity = 0.039,
                            MaxGravity = 0.608,
                            MinTemperature = 145.0,
                            MaxTemperature = 400.0,
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial02] = new SpeciesRules
                {
                    Name = "Bacterium Nebulus",
                    Value = 5289900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Helium" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.4,
                            MaxGravity = 0.55,
                            MinTemperature = 20.0,
                            MaxTemperature = 21.0,
                            MinPressure = 0.067,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Helium" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body" ),
                            MinGravity = 0.4,
                            MaxGravity = 0.7,
                            MinTemperature = 20.0,
                            MaxTemperature = 21.0,
                            MinPressure = 0.067,
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial03] = new SpeciesRules
                {
                    Name = "Bacterium Scopulum",
                    Value = 4934500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.15,
                            MaxGravity = 0.26,
                            MinTemperature = 56,
                            MaxTemperature = 150,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon dioxide", "methane" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Helium" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.48,
                            MaxGravity = 0.51,
                            MinTemperature = 20,
                            MaxTemperature = 21,
                            MinPressure = 0.075,
                            Volcanism = VolcanismRequirement.FromStrings( "methane" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.047,
                            MinTemperature = 84,
                            MaxTemperature = 110,
                            MinPressure = 0.03,
                            Volcanism = VolcanismRequirement.FromStrings( "methane" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.61,
                            MinTemperature = 20,
                            MaxTemperature = 65,
                            MaxPressure = 0.008,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon dioxide", "methane" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "NeonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.61,
                            MinTemperature = 20,
                            MaxTemperature = 65,
                            MinPressure = 0.005,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon dioxide", "methane" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.2,
                            MaxGravity = 0.3,
                            MinTemperature = 60,
                            MaxTemperature = 70,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon dioxide", "methane" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.27,
                            MaxGravity = 0.4,
                            MinTemperature = 150,
                            MaxTemperature = 220,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "carbon dioxide", "methane" ),
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial04] = new SpeciesRules
                {
                    Name = "Bacterium Acies",
                    Value = 1000000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.255,
                            MaxGravity = 0.61,
                            MinTemperature = 20.0,
                            MaxTemperature = 61.0,
                            MaxPressure = 0.01,
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial05] = new SpeciesRules
                {
                    Name = "Bacterium Vesicula",
                    Value = 1000000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            MinGravity = 0.027,
                            MaxGravity = 0.51,
                            MinTemperature = 50.0,
                            MaxTemperature = 245.0,
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial06] = new SpeciesRules
                {
                    Name = "Bacterium Alcyoneum",
                    Value = 1658500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.376,
                            MinTemperature = 152.0,
                            MaxTemperature = 177.0,
                            MaxPressure = 0.0135,
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial07] = new SpeciesRules
                {
                    Name = "Bacterium Tela",
                    Value = 1949000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.045,
                            MaxGravity = 0.45,
                            MinTemperature = 50.0,
                            MaxTemperature = 200.0,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "ArgonRich" ),
                            MinGravity = 0.24,
                            MaxGravity = 0.45,
                            MinTemperature = 50.0,
                            MaxTemperature = 150.0,
                            MaxPressure = 0.05,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.23,
                            MinTemperature = 165.0,
                            MaxTemperature = 177.0,
                            MinPressure = 0.0025,
                            MaxPressure = 0.02,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide" ),
                            MinGravity = 0.45,
                            MaxGravity = 0.61,
                            MinTemperature = 300.0,
                            MaxTemperature = 500.0,
                            MinPressure = 0.006,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide", "CarbonDioxideRich" ),
                            MinGravity = 0.26,
                            MaxGravity = 0.57,
                            MinTemperature = 167.0,
                            MaxTemperature = 300.0,
                            MinPressure = 0.006,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Helium" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.025,
                            MaxGravity = 0.61,
                            MinTemperature = 20.0,
                            MaxTemperature = 21.0,
                            MinPressure = 0.067,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky body", "High metal content body" ),
                            MinGravity = 0.026,
                            MaxGravity = 0.126,
                            MinTemperature = 80.0,
                            MaxTemperature = 109.0,
                            MinPressure = 0.012,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.27,
                            MaxGravity = 0.61,
                            MinTemperature = 20.0,
                            MaxTemperature = 95.0,
                            MaxPressure = 0.008,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "NeonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.27,
                            MaxGravity = 0.61,
                            MinTemperature = 20.0,
                            MaxTemperature = 95.0,
                            MinPressure = 0.003,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            MinGravity = 0.21,
                            MaxGravity = 0.35,
                            MinTemperature = 55.0,
                            MaxTemperature = 80.0,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            MinGravity = 0.23,
                            MaxGravity = 0.5,
                            MinTemperature = 150.0,
                            MaxTemperature = 240.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.18,
                            MaxGravity = 0.61,
                            MinTemperature = 148.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.18,
                            MaxGravity = 0.61,
                            MinTemperature = 300.0,
                            MaxTemperature = 500.0,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.5,
                            MaxGravity = 0.55,
                            MinTemperature = 500.0,
                            MaxTemperature = 650.0,
                            Volcanism = VolcanismRequirement.Any,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.063,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "WaterRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body", "Rocky ice body" ),
                            MinGravity = 0.315,
                            MaxGravity = 0.44,
                            MinTemperature = 220.0,
                            MaxTemperature = 330.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.Any,
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial08] = new SpeciesRules
                {
                    Name = "Bacterium Informem",
                    Value = 8418000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                            MinGravity = 0.05,
                            MaxGravity = 0.6,
                            MinTemperature = 42.5,
                            MaxTemperature = 151.0,
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.17,
                            MaxGravity = 0.63,
                            MinTemperature = 50.0,
                            MaxTemperature = 90.0,
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial09] = new SpeciesRules
                {
                    Name = "Bacterium Volu",
                    Value = 7774700,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            MinGravity = 0.239,
                            MaxGravity = 0.61,
                            MinTemperature = 143.5,
                            MaxTemperature = 246.0,
                            MinPressure = 0.013,
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial10] = new SpeciesRules
                {
                    Name = "Bacterium Bullaris",
                    Value = 1152500,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            MinGravity = 0.0245,
                            MaxGravity = 0.35,
                            MinTemperature = 67.0,
                            MaxTemperature = 109.0,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "MethaneRich" ),
                            MinGravity = 0.44,
                            MaxGravity = 0.6,
                            MinTemperature = 74.0,
                            MaxTemperature = 141.0,
                            MinPressure = 0.01,
                            MaxPressure = 0.05,
                            Volcanism = VolcanismRequirement.None,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial11] = new SpeciesRules
                {
                    Name = "Bacterium Omentum",
                    Value = 4638900,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.045,
                            MaxGravity = 0.45,
                            MinTemperature = 50.0,
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "ArgonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.23,
                            MaxGravity = 0.45,
                            MinTemperature = 80.0,
                            MaxTemperature = 90.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Helium" ),
                            MinGravity = 0.4,
                            MaxGravity = 0.51,
                            MinTemperature = 20.0,
                            MaxTemperature = 21.0,
                            MinPressure = 0.065,
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Methane" ),
                            MinGravity = 0.0265,
                            MaxGravity = 0.0455,
                            MinTemperature = 84.0,
                            MaxTemperature = 108.0,
                            MinPressure = 0.035,
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon" ),
                            MinGravity = 0.31,
                            MaxGravity = 0.6,
                            MinTemperature = 20.0,
                            MaxTemperature = 61.0,
                            MaxPressure = 0.0065,
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "NeonRich" ),
                            MinGravity = 0.27,
                            MaxGravity = 0.61,
                            MinTemperature = 20.0,
                            MaxTemperature = 93.0,
                            MinPressure = 0.0027,
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            MinGravity = 0.2,
                            MaxGravity = 0.26,
                            MinTemperature = 60.0,
                            MaxTemperature = 80.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "WaterRich" ),
                            MinGravity = 0.38,
                            MaxGravity = 0.45,
                            MinTemperature = 190.0,
                            MaxTemperature = 320.0,
                            MinPressure = 0.07,
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            Volcanism = VolcanismRequirement.FromStrings( "nitrogen", "ammonia" ),
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial12] = new SpeciesRules
                {
                    Name = "Bacterium Cerbrus",
                    Value = 1689800,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "SulphurDioxide" ),
                            MinGravity = 0.042,
                            MaxGravity = 0.605,
                            MinTemperature = 132.0,
                            MaxTemperature = 500.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "High metal content body" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.064,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            Volcanism = VolcanismRequirement.None,
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.064,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "High metal content body" ),
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "WaterRich" ),
                            MinGravity = 0.4,
                            MaxGravity = 0.5,
                            MinTemperature = 240.0,
                            MaxTemperature = 320.0,
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body" ),
                            Volcanism = VolcanismRequirement.None,
                        }
                    }
                }
,
                [Genus.Bacterial.Species.Bacterial13] = new SpeciesRules
                {
                    Name = "Bacterium Verrata",
                    Value = 3897000,
                    Rulesets = new List<Ruleset>
                    {
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Ammonia" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body", "Rocky ice body", "Icy body" ),
                            MinGravity = 0.03,
                            MaxGravity = 0.09,
                            MinTemperature = 160.0,
                            MaxTemperature = 180.0,
                            MaxPressure = 0.0135,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Argon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body", "Icy body" ),
                            MinGravity = 0.165,
                            MaxGravity = 0.33,
                            MinTemperature = 57.5,
                            MaxTemperature = 145.0,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "ArgonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.08,
                            MinTemperature = 80.0,
                            MaxTemperature = 90.0,
                            MaxPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "CarbonDioxide", "CarbonDioxideRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body", "Icy body" ),
                            MinGravity = 0.25,
                            MaxGravity = 0.32,
                            MinTemperature = 167.0,
                            MaxTemperature = 240.0,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Helium" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.49,
                            MaxGravity = 0.53,
                            MinTemperature = 20.0,
                            MaxTemperature = 21.0,
                            MinPressure = 0.065,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Neon" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body", "Icy body" ),
                            MinGravity = 0.29,
                            MaxGravity = 0.61,
                            MinTemperature = 20.0,
                            MaxTemperature = 51.0,
                            MaxPressure = 0.075,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "NeonRich" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body", "Icy body" ),
                            MinGravity = 0.43,
                            MaxGravity = 0.61,
                            MinTemperature = 20.0,
                            MaxTemperature = 65.0,
                            MinPressure = 0.005,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Nitrogen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Icy body" ),
                            MinGravity = 0.205,
                            MaxGravity = 0.241,
                            MinTemperature = 60.0,
                            MaxTemperature = 80.0,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Oxygen" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky ice body", "Icy body" ),
                            MinGravity = 0.24,
                            MaxGravity = 0.35,
                            MinTemperature = 154.0,
                            MaxTemperature = 220.0,
                            MinPressure = 0.01,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
,
                        new Ruleset
                        {
                            Atmosphere = AtmosphereRequirement.FromStrings( "Water" ),
                            BodyType = BodyTypeRequirement.FromStrings( "Rocky body" ),
                            MinGravity = 0.04,
                            MaxGravity = 0.054,
                            Volcanism = VolcanismRequirement.FromStrings( "water" ),
                        }
                    }
                }
            }
        };
    }
}