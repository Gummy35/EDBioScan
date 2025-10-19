using ExoScan.CodexData;
using ExoScan.Enums;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{
    /// <summary>
    /// Represents color information for a genus or species
    /// </summary>
    public class ColorInfo
    {
        /// <summary>
        /// Star type to color mappings (for genus-level or species-level)
        /// </summary>
        public Dictionary<StarType, string> Star { get; set; }

        /// <summary>
        /// Element to color mappings (for species-level)
        /// </summary>
        public Dictionary<string, string> Element { get; set; }

        public ColorInfo()
        {
            Star = new Dictionary<StarType, string>();
            Element = new Dictionary<string, string>();
        }
    }

    /// <summary>
    /// Represents genus information including name, distance, and color data
    /// </summary>
    public class GenusInfo
    {
        /// <summary>
        /// Display name of the genus
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Minimum distance between samples (in meters)
        /// </summary>
        public int Distance { get; set; }

        /// <summary>
        /// Whether this genus can have multiple species in the same location
        /// </summary>
        public bool Multiple { get; set; }

        /// <summary>
        /// Color information - can be at genus level or species level
        /// </summary>
        public GenusColors Colors { get; set; }

        public GenusInfo()
        {
            Colors = new GenusColors();
        }
    }

    /// <summary>
    /// Container for color information at genus or species level
    /// </summary>
    public class GenusColors
    {
        /// <summary>
        /// Genus-level color mappings (star types to colors)
        /// </summary>
        public Dictionary<StarType, string> Star { get; set; }

        /// <summary>
        /// Species-level color mappings (species ID to ColorInfo)
        /// </summary>
        public Dictionary<ushort, ColorInfo> Species { get; set; }

        public GenusColors()
        {
            Star = new Dictionary<StarType, string>();
            Species = new Dictionary<ushort, ColorInfo>();
        }
    }

    /// <summary>
    /// Contains all genus data
    /// </summary>
    public static class GenusData
    {
        public static readonly Dictionary<GenusEnum, GenusInfo> Data = new Dictionary<GenusEnum, GenusInfo>
        {
            [GenusEnum.Aleoids] = new GenusInfo
            {
                Name = "Aleoida",
                Distance = 150,
                Multiple = false,
                Colors = new GenusColors
                {
                    Star = new Dictionary<StarType, string>
                    {
                        { StarType.B, "Yellow" },
                        { StarType.A, "Green" },
                        { StarType.F, "Teal" },
                        { StarType.K, "Turquoise" },
                        { StarType.M, "Emerald" },
                        { StarType.L, "Lime" },
                        { StarType.T, "Sage" },
                        { StarType.TTS, "Mauve" },
                        { StarType.D, "Indigo" },
                        { StarType.W, "Grey" },
                        { StarType.Y, "Amethyst" },
                        { StarType.N, "Ocher" }
                    }
                }
            },

            [GenusEnum.Bacterial] = new GenusInfo
            {
                Name = "Bacterium",
                Distance = 500,
                Multiple = false,
                Colors = new GenusColors
                {
                    Species = new Dictionary<ushort, ColorInfo>
                    {
                        [Genus.Bacterial.Species.Bacterial01] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.O, "Turquoise" },
                                { StarType.B, "Grey" },
                                { StarType.A, "Yellow" },
                                { StarType.F, "Lime" },
                                { StarType.G, "Emerald" },
                                { StarType.K, "Green" },
                                { StarType.M, "Teal" },
                                { StarType.L, "Sage" },
                                { StarType.T, "Red" },
                                { StarType.Y, "Mauve" },
                                { StarType.TTS, "Maroon" },
                                { StarType.AeBe, "Orange" },
                                { StarType.W, "Amethyst" },
                                { StarType.D, "Ocher" },
                                { StarType.N, "Indigo" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial02] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Magenta" },
                                { "polonium", "Gold" },
                                { "ruthenium", "Orange" },
                                { "technetium", "Cyan" },
                                { "tellurium", "Green" },
                                { "yttrium", "Cobalt" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial03] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "White" },
                                { "mercury", "Peach" },
                                { "molybdenum", "Lime" },
                                { "niobium", "Red" },
                                { "tungsten", "Aquamarine" },
                                { "tin", "Mulberry" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial04] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Cyan" },
                                { "polonium", "Magenta" },
                                { "ruthenium", "Cobalt" },
                                { "technetium", "Lime" },
                                { "tellurium", "White" },
                                { "yttrium", "Aquamarine" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial05] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Cyan" },
                                { "polonium", "Orange" },
                                { "ruthenium", "Mulberry" },
                                { "technetium", "Gold" },
                                { "tellurium", "Red" },
                                { "yttrium", "Lime" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial06] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.O, "Turquoise" },
                                { StarType.B, "Grey" },
                                { StarType.A, "Yellow" },
                                { StarType.F, "Lime" },
                                { StarType.G, "Emerald" },
                                { StarType.K, "Green" },
                                { StarType.M, "Teal" },
                                { StarType.L, "Sage" },
                                { StarType.T, "Red" },
                                { StarType.Y, "Mauve" },
                                { StarType.TTS, "Maroon" },
                                { StarType.AeBe, "Orange" },
                                { StarType.W, "Amethyst" },
                                { StarType.D, "Ocher" },
                                { StarType.N, "Indigo" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial07] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "Gold" },
                                { "mercury", "Orange" },
                                { "molybdenum", "Yellow" },
                                { "niobium", "Magenta" },
                                { "tungsten", "Green" },
                                { "tin", "Cobalt" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial08] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Red" },
                                { "polonium", "Lime" },
                                { "ruthenium", "Gold" },
                                { "technetium", "Aquamarine" },
                                { "tellurium", "Yellow" },
                                { "yttrium", "Cobalt" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial09] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Red" },
                                { "polonium", "Aquamarine" },
                                { "ruthenium", "Cobalt" },
                                { "technetium", "Lime" },
                                { "tellurium", "Cyan" },
                                { "yttrium", "Gold" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial10] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Cobalt" },
                                { "polonium", "Yellow" },
                                { "ruthenium", "Aquamarine" },
                                { "technetium", "Gold" },
                                { "tellurium", "Lime" },
                                { "yttrium", "Red" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial11] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "Lime" },
                                { "mercury", "White" },
                                { "molybdenum", "Aquamarine" },
                                { "niobium", "Peach" },
                                { "tungsten", "Blue" },
                                { "tin", "Red" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial12] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.O, "Turquoise" },
                                { StarType.B, "Grey" },
                                { StarType.A, "Yellow" },
                                { StarType.F, "Lime" },
                                { StarType.G, "Emerald" },
                                { StarType.K, "Green" },
                                { StarType.M, "Teal" },
                                { StarType.L, "Sage" },
                                { StarType.T, "Red" },
                                { StarType.Y, "Mauve" },
                                { StarType.TTS, "Maroon" },
                                { StarType.AeBe, "Orange" },
                                { StarType.W, "Amethyst" },
                                { StarType.D, "Ocher" },
                                { StarType.N, "Indigo" }
                            }
                        },
                        [Genus.Bacterial.Species.Bacterial13] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "Peach" },
                                { "mercury", "Red" },
                                { "molybdenum", "White" },
                                { "niobium", "Mulberry" },
                                { "tungsten", "Lime" },
                                { "tin", "Blue" }
                            }
                        }
                    }
                }
            },

            [GenusEnum.Cactoid] = new GenusInfo
            {
                Name = "Cactoida",
                Distance = 300,
                Multiple = false,
                Colors = new GenusColors
                {
                    Star = new Dictionary<StarType, string>
                    {
                        { StarType.O, "Grey" },
                        { StarType.A, "Green" },
                        { StarType.G, "Teal" },
                        { StarType.F, "Yellow" },
                        { StarType.M, "Amethyst" },
                        { StarType.L, "Mauve" },
                        { StarType.T, "Orange" },
                        { StarType.Y, "Ocher" },
                        { StarType.TTS, "Red" },
                        { StarType.W, "Indigo" },
                        { StarType.D, "Turquoise" },
                        { StarType.N, "Sage" }
                    }
                }
            },

            [GenusEnum.Clypeus] = new GenusInfo
            {
                Name = "Clypeus",
                Distance = 150,
                Multiple = false,
                Colors = new GenusColors
                {
                    Star = new Dictionary<StarType, string>
                    {
                        { StarType.B, "Maroon" },
                        { StarType.A, "Orange" },
                        { StarType.G, "Amethyst" },
                        { StarType.F, "Mauve" },
                        { StarType.K, "Grey" },
                        { StarType.M, "Turquoise" },
                        { StarType.L, "Teal" },
                        { StarType.Y, "Green" },
                        { StarType.D, "Lime" },
                        { StarType.N, "Yellow" }
                    }
                }
            },

            [GenusEnum.Conchas] = new GenusInfo
            {
                Name = "Concha",
                Distance = 150,
                Multiple = false,
                Colors = new GenusColors
                {
                    Species = new Dictionary<ushort, ColorInfo>
                    {
                        [Genus.Conchas.Species.Conchas01] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "Red" },
                                { "mercury", "Mulberry" },
                                { "molybdenum", "Peach" },
                                { "niobium", "Blue" },
                                { "tungsten", "White" },
                                { "tin", "Aquamarine" }
                            }
                        },
                        [Genus.Conchas.Species.Conchas02] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.B, "Indigo" },
                                { StarType.A, "Teal" },
                                { StarType.F, "Grey" },
                                { StarType.G, "Turquoise" },
                                { StarType.K, "Red" },
                                { StarType.L, "Orange" },
                                { StarType.Y, "Yellow" },
                                { StarType.W, "Lime" },
                                { StarType.D, "Green" },
                                { StarType.N, "Emerald" }
                            }
                        },
                        [Genus.Conchas.Species.Conchas03] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.B, "Indigo" },
                                { StarType.A, "Teal" },
                                { StarType.F, "Grey" },
                                { StarType.G, "Turquoise" },
                                { StarType.K, "Red" },
                                { StarType.L, "Orange" },
                                { StarType.Y, "Yellow" },
                                { StarType.W, "Lime" },
                                { StarType.D, "Green" },
                                { StarType.N, "Emerald" }
                            }
                        },
                        [Genus.Conchas.Species.Conchas04] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Peach" },
                                { "polonium", "Red" },
                                { "ruthenium", "Orange" },
                                { "technetium", "White" },
                                { "tellurium", "Yellow" },
                                { "yttrium", "Gold" }
                            }
                        }
                    }
                }
            },

            [GenusEnum.Cone] = new GenusInfo
            {
                Name = "Bark Mound",
                Distance = 100,
                Multiple = false
            },

            [GenusEnum.Electricae] = new GenusInfo
            {
                Name = "Electricae",
                Distance = 1000,
                Multiple = false,
                Colors = new GenusColors
                {
                    Species = new Dictionary<ushort, ColorInfo>
                    {
                        [Genus.Electricae.Species.Electricae01] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Cobalt" },
                                { "polonium", "Cyan" },
                                { "ruthenium", "Blue" },
                                { "technetium", "Magenta" },
                                { "tellurium", "Red" },
                                { "yttrium", "Mulberry" }
                            }
                        },
                        [Genus.Electricae.Species.Electricae02] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Cyan" },
                                { "polonium", "Cobalt" },
                                { "ruthenium", "Blue" },
                                { "technetium", "Aquamarine" },
                                { "tellurium", "Magenta" },
                                { "yttrium", "Green" }
                            }
                        }
                    }
                }
            },

            [GenusEnum.Fonticulus] = new GenusInfo
            {
                Name = "Fonticulua",
                Distance = 500,
                Multiple = false,
                Colors = new GenusColors
                {
                    Star = new Dictionary<StarType, string>
                    {
                        { StarType.O, "Grey" },
                        { StarType.B, "Lime" },
                        { StarType.A, "Green" },
                        { StarType.F, "Yellow" },
                        { StarType.G, "Teal" },
                        { StarType.K, "Emerald" },
                        { StarType.M, "Amethyst" },
                        { StarType.L, "Mauve" },
                        { StarType.T, "Orange" },
                        { StarType.TTS, "Red" },
                        { StarType.Y, "Ocher" },
                        { StarType.W, "Indigo" },
                        { StarType.D, "Turquoise" },
                        { StarType.N, "Sage" },
                        { StarType.AeBe, "Maroon" }
                    }
                }
            },

            [GenusEnum.Fumerolas] = new GenusInfo
            {
                Name = "Fumerola",
                Distance = 100,
                Multiple = false,
                Colors = new GenusColors
                {
                    Species = new Dictionary<ushort, ColorInfo>
                    {
                        [Genus.Fumerolas.Species.Fumerolas01] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "Orange" },
                                { "mercury", "Magenta" },
                                { "molybdenum", "Gold" },
                                { "niobium", "Cobalt" },
                                { "tungsten", "Yellow" },
                                { "tin", "Cyan" }
                            }
                        },
                        [Genus.Fumerolas.Species.Fumerolas02] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "Aquamarine" },
                                { "mercury", "Lime" },
                                { "molybdenum", "Blue" },
                                { "niobium", "White" },
                                { "tungsten", "Mulberry" },
                                { "tin", "Peach" }
                            }
                        },
                        [Genus.Fumerolas.Species.Fumerolas03] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "White" },
                                { "mercury", "Peach" },
                                { "molybdenum", "Lime" },
                                { "niobium", "Red" },
                                { "tungsten", "Aquamarine" },
                                { "tin", "Mulberry" }
                            }
                        },
                        [Genus.Fumerolas.Species.Fumerolas04] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "Green" },
                                { "mercury", "Yellow" },
                                { "molybdenum", "Cyan" },
                                { "niobium", "Gold" },
                                { "tungsten", "Cobalt" },
                                { "tin", "Orange" }
                            }
                        }
                    }
                }
            },

            [GenusEnum.Fungoids] = new GenusInfo
            {
                Name = "Fungoida",
                Distance = 300,
                Multiple = false,
                Colors = new GenusColors
                {
                    Species = new Dictionary<ushort, ColorInfo>
                    {
                        [Genus.Fungoids.Species.Fungoids01] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Peach" },
                                { "polonium", "White" },
                                { "ruthenium", "Gold" },
                                { "technetium", "Lime" },
                                { "tellurium", "Yellow" },
                                { "yttrium", "Orange" }
                            }
                        },
                        [Genus.Fungoids.Species.Fungoids02] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "Blue" },
                                { "mercury", "Green" },
                                { "molybdenum", "Magenta" },
                                { "niobium", "White" },
                                { "tungsten", "Peach" },
                                { "tin", "Orange" }
                            }
                        },
                        [Genus.Fungoids.Species.Fungoids03] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Red" },
                                { "polonium", "Mulberry" },
                                { "ruthenium", "Magenta" },
                                { "technetium", "Peach" },
                                { "tellurium", "Gold" },
                                { "yttrium", "Orange" }
                            }
                        },
                        [Genus.Fungoids.Species.Fungoids04] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "Cyan" },
                                { "mercury", "Lime" },
                                { "molybdenum", "Mulberry" },
                                { "niobium", "Green" },
                                { "tungsten", "Orange" },
                                { "tin", "Red" }
                            }
                        }
                    }
                }
            },

            [GenusEnum.GroundStructIce] = new GenusInfo
            {
                Name = "Crystalline Shards",
                Distance = 100,
                Multiple = false
            },

            [GenusEnum.Osseus] = new GenusInfo
            {
                Name = "Osseus",
                Distance = 800,
                Multiple = false,
                Colors = new GenusColors
                {
                    Species = new Dictionary<ushort, ColorInfo>
                    {
                        [Genus.Osseus.Species.Osseus01] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.O, "Yellow" },
                                { StarType.A, "Lime" },
                                { StarType.F, "Turquoise" },
                                { StarType.G, "Grey" },
                                { StarType.K, "Indigo" },
                                { StarType.T, "Emerald" },
                                { StarType.Y, "Maroon" },
                                { StarType.TTS, "Green" }
                            }
                        },
                        [Genus.Osseus.Species.Osseus02] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "White" },
                                { "mercury", "Lime" },
                                { "molybdenum", "Peach" },
                                { "niobium", "Aquamarine" },
                                { "tungsten", "Red" },
                                { "tin", "Blue" }
                            }
                        },
                        [Genus.Osseus.Species.Osseus03] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.O, "Yellow" },
                                { StarType.A, "Lime" },
                                { StarType.F, "Turquoise" },
                                { StarType.G, "Grey" },
                                { StarType.K, "Indigo" },
                                { StarType.T, "Emerald" },
                                { StarType.Y, "Maroon" },
                                { StarType.TTS, "Green" }
                            }
                        },
                        [Genus.Osseus.Species.Osseus04] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "White" },
                                { "polonium", "Peach" },
                                { "ruthenium", "Gold" },
                                { "technetium", "Lime" },
                                { "tellurium", "Green" },
                                { "yttrium", "Yellow" }
                            }
                        },
                        [Genus.Osseus.Species.Osseus05] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.O, "Yellow" },
                                { StarType.A, "Lime" },
                                { StarType.F, "Turquoise" },
                                { StarType.G, "Grey" },
                                { StarType.K, "Indigo" },
                                { StarType.T, "Emerald" },
                                { StarType.Y, "Maroon" },
                                { StarType.TTS, "Green" }
                            }
                        },
                        [Genus.Osseus.Species.Osseus06] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.O, "Yellow" },
                                { StarType.A, "Lime" },
                                { StarType.F, "Turquoise" },
                                { StarType.G, "Grey" },
                                { StarType.K, "Indigo" },
                                { StarType.T, "Emerald" },
                                { StarType.Y, "Maroon" },
                                { StarType.TTS, "Green" }
                            }
                        }
                    }
                }
            },

            [GenusEnum.Recepta] = new GenusInfo
            {
                Name = "Recepta",
                Distance = 150,
                Multiple = false,
                Colors = new GenusColors
                {
                    Species = new Dictionary<ushort, ColorInfo>
                    {
                        [Genus.Recepta.Species.Recepta01] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.B, "Turquoise" },
                                { StarType.A, "Amethyst" },
                                { StarType.F, "Mauve" },
                                { StarType.G, "Orange" },
                                { StarType.K, "Red" },
                                { StarType.M, "Maroon" },
                                { StarType.T, "Teal" },
                                { StarType.Y, "Lime" },
                                { StarType.TTS, "Sage" },
                                { StarType.L, "Ocher" },
                                { StarType.AeBe, "Grey" },
                                { StarType.D, "Yellow" },
                                { StarType.N, "Emerald" }
                            }
                        },
                        [Genus.Recepta.Species.Recepta02] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "cadmium", "Lime" },
                                { "mercury", "Cyan" },
                                { "molybdenum", "Gold" },
                                { "niobium", "Mulberry" },
                                { "tungsten", "Red" },
                                { "tin", "Orange" }
                            }
                        },
                        [Genus.Recepta.Species.Recepta03] = new ColorInfo
                        {
                            Element = new Dictionary<string, string>
                            {
                                { "antimony", "Lime" },
                                { "polonium", "White" },
                                { "ruthenium", "Yellow" },
                                { "technetium", "Aquamarine" },
                                { "tellurium", "Cyan" },
                                { "yttrium", "Green" }
                            }
                        }
                    }
                }
            },

            [GenusEnum.Brancae] = new GenusInfo
            {
                Name = "Brain Tree",
                Distance = 100,
                Multiple = true
            },

            [GenusEnum.Shrubs] = new GenusInfo
            {
                Name = "Frutexa",
                Distance = 150,
                Multiple = false,
                Colors = new GenusColors
                {
                    Star = new Dictionary<StarType, string>
                    {
                        { StarType.O, "Yellow" },
                        { StarType.B, "Lime" },
                        { StarType.F, "Green" },
                        { StarType.G, "Emerald" },
                        { StarType.M, "Grey" },
                        { StarType.L, "Teal" },
                        { StarType.TTS, "Mauve" },
                        { StarType.W, "Orange" },
                        { StarType.D, "Indigo" },
                        { StarType.N, "Red" }
                    }
                }
            },

            [GenusEnum.Sphere] = new GenusInfo
            {
                Name = "Anemone",
                Distance = 100,
                Multiple = false
            },

            [GenusEnum.Stratum] = new GenusInfo
            {
                Name = "Stratum",
                Distance = 500,
                Multiple = false,
                Colors = new GenusColors
                {
                    Species = new Dictionary<ushort, ColorInfo>
                    {
                        [Genus.Stratum.Species.Stratum01] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.F, "Emerald" },
                                { StarType.K, "Lime" },
                                { StarType.M, "Green" },
                                { StarType.L, "Turquoise" },
                                { StarType.Y, "Indigo" },
                                { StarType.T, "Grey" },
                                { StarType.TTS, "Amethyst" },
                                { StarType.D, "Mauve" },
                                { StarType.AeBe, "Teal" },
                                { StarType.W, "Red" }
                            }
                        },
                        [Genus.Stratum.Species.Stratum02] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.F, "Emerald" },
                                { StarType.K, "Lime" },
                                { StarType.M, "Green" },
                                { StarType.L, "Turquoise" },
                                { StarType.Y, "Indigo" },
                                { StarType.T, "Grey" },
                                { StarType.TTS, "Amethyst" },
                                { StarType.D, "Mauve" },
                                { StarType.AeBe, "Teal" },
                                { StarType.W, "Red" }
                            }
                        },
                        [Genus.Stratum.Species.Stratum03] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.F, "Emerald" },
                                { StarType.K, "Lime" },
                                { StarType.M, "Green" },
                                { StarType.L, "Turquoise" },
                                { StarType.Y, "Indigo" },
                                { StarType.T, "Grey" },
                                { StarType.TTS, "Amethyst" },
                                { StarType.D, "Mauve" },
                                { StarType.AeBe, "Teal" },
                                { StarType.W, "Red" }
                            }
                        },
                        [Genus.Stratum.Species.Stratum04] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.B, "Emerald" },
                                { StarType.A, "Emerald" },
                                { StarType.N, "Emerald" }
                            }
                        },
                        [Genus.Stratum.Species.Stratum05] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.F, "Emerald" },
                                { StarType.K, "Lime" },
                                { StarType.M, "Green" },
                                { StarType.L, "Turquoise" },
                                { StarType.Y, "Indigo" },
                                { StarType.T, "Grey" },
                                { StarType.TTS, "Amethyst" },
                                { StarType.D, "Mauve" },
                                { StarType.AeBe, "Teal" },
                                { StarType.W, "Red" }
                            }
                        },
                        [Genus.Stratum.Species.Stratum06] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.F, "Emerald" },
                                { StarType.K, "Lime" },
                                { StarType.M, "Green" },
                                { StarType.L, "Turquoise" },
                                { StarType.Y, "Indigo" },
                                { StarType.T, "Grey" },
                                { StarType.TTS, "Amethyst" },
                                { StarType.D, "Mauve" },
                                { StarType.AeBe, "Teal" },
                                { StarType.W, "Red" }
                            }
                        },
                        [Genus.Stratum.Species.Stratum07] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.F, "Emerald" },
                                { StarType.K, "Lime" },
                                { StarType.M, "Green" },
                                { StarType.L, "Turquoise" },
                                { StarType.Y, "Indigo" },
                                { StarType.T, "Grey" },
                                { StarType.TTS, "Amethyst" },
                                { StarType.D, "Mauve" },
                                { StarType.AeBe, "Teal" },
                                { StarType.W, "Red" }
                            }
                        },
                        [Genus.Stratum.Species.Stratum08] = new ColorInfo
                        {
                            Star = new Dictionary<StarType, string>
                            {
                                { StarType.F, "Emerald" },
                                { StarType.K, "Lime" },
                                { StarType.M, "Green" },
                                { StarType.L, "Turquoise" },
                                { StarType.Y, "Indigo" },
                                { StarType.T, "Grey" },
                                { StarType.TTS, "Amethyst" },
                                { StarType.D, "Mauve" },
                                { StarType.AeBe, "Teal" },
                                { StarType.W, "Red" }
                            }
                        }
                    }
                }
            },

            //// Note: Aranaemus breaks typical naming convention
            //[GenusEnum.Stratum.Species.Stratum04] = new GenusInfo
            //{
            //    Name = "Stratum",
            //    Distance = 500,
            //    Multiple = false,
            //    Colors = new GenusColors
            //    {
            //        Star = new Dictionary<StarTypeEnum, string>
            //        {
            //            { StarTypeEnum.F, "Emerald" }
            //        }
            //    }
            //},

            [GenusEnum.Tube] = new GenusInfo
            {
                Name = "Sinuous Tubers",
                Distance = 100,
                Multiple = true
            },

            [GenusEnum.Tubus] = new GenusInfo
            {
                Name = "Tubus",
                Distance = 800,
                Multiple = false,
                Colors = new GenusColors
                {
                    Star = new Dictionary<StarType, string>
                    {
                        { StarType.O, "Green" },
                        { StarType.B, "Emerald" },
                        { StarType.A, "Indigo" },
                        { StarType.F, "Grey" },
                        { StarType.G, "Red" },
                        { StarType.K, "Maroon" },
                        { StarType.M, "Teal" },
                        { StarType.L, "Turquoise" },
                        { StarType.T, "Mauve" },
                        { StarType.TTS, "Ocher" },
                        { StarType.W, "Lime" },
                        { StarType.D, "Yellow" },
                        { StarType.N, "Amethyst" }
                    }
                }
            },

            [GenusEnum.Tussocks] = new GenusInfo
            {
                Name = "Tussock",
                Distance = 200,
                Multiple = false,
                Colors = new GenusColors
                {
                    Star = new Dictionary<StarType, string>
                    {
                        { StarType.F, "Yellow" },
                        { StarType.G, "Lime" },
                        { StarType.K, "Green" },
                        { StarType.M, "Emerald" },
                        { StarType.L, "Sage" },
                        { StarType.T, "Teal" },
                        { StarType.Y, "Red" },
                        { StarType.W, "Orange" },
                        { StarType.D, "Maroon" },
                        { StarType.N, "Yellow" }
                    }
                }
            },

            [GenusEnum.Vents] = new GenusInfo
            {
                Name = "Amphora Plant",
                Distance = 100,
                Multiple = false
            }
        };

        /// <summary>
        /// Get genus info by codex ID
        /// </summary>
        public static GenusInfo GetGenus(string codexId)
        {
            if (CodexMap.TryGenusFromString(codexId, out var _id))
            {
                return Data.TryGetValue(_id, out var genus) ? genus : null;
            }
            return null;
        }

        public static GenusInfo GetGenus(GenusEnum genus)
        {
            return Data.TryGetValue(genus, out var info) ? info : null;
        }

        /// <summary>
        /// Get color for a genus based on star type
        /// </summary>
        public static string GetGenusColor(GenusEnum genusId, StarType starType)
        {
            if (!Data.TryGetValue(genusId, out var genus))
                return null;

            if (genus.Colors?.Star != null && genus.Colors.Star.TryGetValue(starType, out var color))
                return color;

            return null;
        }

        /// <summary>
        /// Check if genus has species-level colors
        /// </summary>
        public static bool HasSpeciesLevelColors(GenusEnum genusId)
        {
            return Data.TryGetValue(genusId, out var genus) &&
                   genus.Colors?.Species != null &&
                   genus.Colors.Species.Count > 0;
        }

        /// <summary>
        /// Check if genus has genus-level colors
        /// </summary>
        public static bool HasGenusLevelColors(GenusEnum genusId)
        {
            return Data.TryGetValue(genusId, out var genus) &&
                   genus.Colors?.Star != null &&
                   genus.Colors.Star.Count > 0;
        }

        public static string GetSpeciesName(ushort species)
        {
            var result = "";
            var genusId = (GenusEnum)(CodexIds.GetGenus(species));
            if (BioRules.Rules.TryGetValue(genusId, out var rules))
            {
                if (rules.TryGetValue(species, out var rule))
                {
                    result = rule.Name;
                }
                else
                {
                    result = Data[genusId].Name;
                }
            }
            else result = "Unknown";
            return result;
        }
    }
}