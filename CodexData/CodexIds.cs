namespace ExoScan.CodexData
{
    public static class CodexIds
    {
        // Encoding: 0xGGSS -> GG = genus (8 bits), SS = species (8 bits)
        public static ushort MakeId(byte genus, byte species) => (ushort)((genus << 8) | species);
        public static byte GetGenus(ushort id) => (byte)(id >> 8);
        public static byte GetSpecies(ushort id) => (byte)(id & 0xFF);

        public enum GenusEnum : byte
        {
            Cone = 0,
            GroundStructIce = 1,
            Vents = 2,
            Aleoids = 3,
            Sphere = 4,
            Bacterial = 5,
            Brancae = 6,
            Cactoid = 7,
            Clypeus = 8,
            Conchas = 9,
            Electricae = 10,
            Fonticulus = 11,
            Shrubs = 12,
            Fumerolas = 13,
            Fungoids = 14,
            Osseus = 15,
            Recepta = 16,
            Stratum = 17,
            Tube = 18,
            Tubus = 19,
            Tussocks = 20,
            Aranaemus = 21,
        }

        public static class Genus
        {
            /// <summary>Cone genus</summary>
            public static class Cone
            {
                public const byte Id = 0;
                public static class Species
                {
                    /// <summary>Root species</summary>
                    public const ushort Root = (Id << 8) | 0; // 0x0000
                }
            }

            /// <summary>GroundStructIce genus</summary>
            public static class GroundStructIce
            {
                public const byte Id = 1;
                public static class Species
                {
                    /// <summary>Root species</summary>
                    public const ushort Root = (Id << 8) | 0; // 0x0100
                }
            }

            /// <summary>Vents genus</summary>
            public static class Vents
            {
                public const byte Id = 2;
                public static class Species
                {
                    /// <summary>Root species</summary>
                    public const ushort Root = (Id << 8) | 0; // 0x0200
                }
            }

            /// <summary>AleoidsGenus genus</summary>
            public static class Aleoids
            {
                public const byte Id = 3;
                public static class Species
                {
                    /// <summary>Aleoids01 species</summary>
                    public const ushort Aleoids01 = (Id << 8) | 1; // 0x0301
                    /// <summary>Aleoids02 species</summary>
                    public const ushort Aleoids02 = (Id << 8) | 2; // 0x0302
                    /// <summary>Aleoids03 species</summary>
                    public const ushort Aleoids03 = (Id << 8) | 3; // 0x0303
                    /// <summary>Aleoids04 species</summary>
                    public const ushort Aleoids04 = (Id << 8) | 4; // 0x0304
                    /// <summary>Aleoids05 species</summary>
                    public const ushort Aleoids05 = (Id << 8) | 5; // 0x0305
                }
            }

            /// <summary>Sphere genus</summary>
            public static class Sphere
            {
                public const byte Id = 4;
                public static class Species
                {
                    /// <summary>Root species</summary>
                    public const ushort Root = (Id << 8) | 0; // 0x0400
                    /// <summary>SphereABCD01 species</summary>
                    public const ushort SphereABCD01 = (Id << 8) | 1; // 0x0401
                    /// <summary>SphereABCD02 species</summary>
                    public const ushort SphereABCD02 = (Id << 8) | 2; // 0x0402
                    /// <summary>SphereABCD03 species</summary>
                    public const ushort SphereABCD03 = (Id << 8) | 3; // 0x0403
                    /// <summary>SphereEFGH01 species</summary>
                    public const ushort SphereEFGH01 = (Id << 8) | 4; // 0x0404
                    /// <summary>SphereEFGH02 species</summary>
                    public const ushort SphereEFGH02 = (Id << 8) | 5; // 0x0405
                    /// <summary>SphereEFGH03 species</summary>
                    public const ushort SphereEFGH03 = (Id << 8) | 6; // 0x0406
                    /// <summary>SphereEFGH species</summary>
                    public const ushort SphereEFGH = (Id << 8) | 7; // 0x0407
                }
            }

            /// <summary>BacterialGenus genus</summary>
            public static class Bacterial
            {
                public const byte Id = 5;
                public static class Species
                {
                    /// <summary>Bacterial01 species</summary>
                    public const ushort Bacterial01 = (Id << 8) | 1; // 0x0501
                    /// <summary>Bacterial02 species</summary>
                    public const ushort Bacterial02 = (Id << 8) | 2; // 0x0502
                    /// <summary>Bacterial03 species</summary>
                    public const ushort Bacterial03 = (Id << 8) | 3; // 0x0503
                    /// <summary>Bacterial04 species</summary>
                    public const ushort Bacterial04 = (Id << 8) | 4; // 0x0504
                    /// <summary>Bacterial05 species</summary>
                    public const ushort Bacterial05 = (Id << 8) | 5; // 0x0505
                    /// <summary>Bacterial06 species</summary>
                    public const ushort Bacterial06 = (Id << 8) | 6; // 0x0506
                    /// <summary>Bacterial07 species</summary>
                    public const ushort Bacterial07 = (Id << 8) | 7; // 0x0507
                    /// <summary>Bacterial08 species</summary>
                    public const ushort Bacterial08 = (Id << 8) | 8; // 0x0508
                    /// <summary>Bacterial09 species</summary>
                    public const ushort Bacterial09 = (Id << 8) | 9; // 0x0509
                    /// <summary>Bacterial10 species</summary>
                    public const ushort Bacterial10 = (Id << 8) | 10; // 0x050A
                    /// <summary>Bacterial11 species</summary>
                    public const ushort Bacterial11 = (Id << 8) | 11; // 0x050B
                    /// <summary>Bacterial12 species</summary>
                    public const ushort Bacterial12 = (Id << 8) | 12; // 0x050C
                    /// <summary>Bacterial13 species</summary>
                    public const ushort Bacterial13 = (Id << 8) | 13; // 0x050D
                }
            }

            /// <summary>Brancae genus</summary>
            public static class Brancae
            {
                public const byte Id = 6;
                public static class Species
                {
                    /// <summary>Seed species</summary>
                    public const ushort Seed = (Id << 8) | 1; // 0x0601
                    /// <summary>SeedABCD01 species</summary>
                    public const ushort SeedABCD01 = (Id << 8) | 2; // 0x0602
                    /// <summary>SeedABCD02 species</summary>
                    public const ushort SeedABCD02 = (Id << 8) | 3; // 0x0603
                    /// <summary>SeedABCD03 species</summary>
                    public const ushort SeedABCD03 = (Id << 8) | 4; // 0x0604
                    /// <summary>SeedEFGH01 species</summary>
                    public const ushort SeedEFGH01 = (Id << 8) | 5; // 0x0605
                    /// <summary>SeedEFGH02 species</summary>
                    public const ushort SeedEFGH02 = (Id << 8) | 6; // 0x0606
                    /// <summary>SeedEFGH03 species</summary>
                    public const ushort SeedEFGH03 = (Id << 8) | 7; // 0x0607
                    /// <summary>SeedEFGH species</summary>
                    public const ushort SeedEFGH = (Id << 8) | 8; // 0x0608
                }
            }

            /// <summary>CactoidGenus genus</summary>
            public static class Cactoid
            {
                public const byte Id = 7;
                public static class Species
                {
                    /// <summary>Cactoid01 species</summary>
                    public const ushort Cactoid01 = (Id << 8) | 1; // 0x0701
                    /// <summary>Cactoid02 species</summary>
                    public const ushort Cactoid02 = (Id << 8) | 2; // 0x0702
                    /// <summary>Cactoid03 species</summary>
                    public const ushort Cactoid03 = (Id << 8) | 3; // 0x0703
                    /// <summary>Cactoid04 species</summary>
                    public const ushort Cactoid04 = (Id << 8) | 4; // 0x0704
                    /// <summary>Cactoid05 species</summary>
                    public const ushort Cactoid05 = (Id << 8) | 5; // 0x0705
                }
            }

            /// <summary>ClypeusGenus genus</summary>
            public static class Clypeus
            {
                public const byte Id = 8;
                public static class Species
                {
                    /// <summary>Clypeus01 species</summary>
                    public const ushort Clypeus01 = (Id << 8) | 1; // 0x0801
                    /// <summary>Clypeus02 species</summary>
                    public const ushort Clypeus02 = (Id << 8) | 2; // 0x0802
                    /// <summary>Clypeus03 species</summary>
                    public const ushort Clypeus03 = (Id << 8) | 3; // 0x0803
                }
            }

            /// <summary>ConchasGenus genus</summary>
            public static class Conchas
            {
                public const byte Id = 9;
                public static class Species
                {
                    /// <summary>Conchas01 species</summary>
                    public const ushort Conchas01 = (Id << 8) | 1; // 0x0901
                    /// <summary>Conchas02 species</summary>
                    public const ushort Conchas02 = (Id << 8) | 2; // 0x0902
                    /// <summary>Conchas03 species</summary>
                    public const ushort Conchas03 = (Id << 8) | 3; // 0x0903
                    /// <summary>Conchas04 species</summary>
                    public const ushort Conchas04 = (Id << 8) | 4; // 0x0904
                }
            }

            /// <summary>ElectricaeGenus genus</summary>
            public static class Electricae
            {
                public const byte Id = 10;
                public static class Species
                {
                    /// <summary>Electricae01 species</summary>
                    public const ushort Electricae01 = (Id << 8) | 1; // 0x0A01
                    /// <summary>Electricae02 species</summary>
                    public const ushort Electricae02 = (Id << 8) | 2; // 0x0A02
                }
            }

            /// <summary>FonticulusGenus genus</summary>
            public static class Fonticulus
            {
                public const byte Id = 11;
                public static class Species
                {
                    /// <summary>Fonticulus01 species</summary>
                    public const ushort Fonticulus01 = (Id << 8) | 1; // 0x0B01
                    /// <summary>Fonticulus02 species</summary>
                    public const ushort Fonticulus02 = (Id << 8) | 2; // 0x0B02
                    /// <summary>Fonticulus03 species</summary>
                    public const ushort Fonticulus03 = (Id << 8) | 3; // 0x0B03
                    /// <summary>Fonticulus04 species</summary>
                    public const ushort Fonticulus04 = (Id << 8) | 4; // 0x0B04
                    /// <summary>Fonticulus05 species</summary>
                    public const ushort Fonticulus05 = (Id << 8) | 5; // 0x0B05
                    /// <summary>Fonticulus06 species</summary>
                    public const ushort Fonticulus06 = (Id << 8) | 6; // 0x0B06
                }
            }

            /// <summary>ShrubsGenus genus</summary>
            public static class Shrubs
            {
                public const byte Id = 12;
                public static class Species
                {
                    /// <summary>Shrubs01 species</summary>
                    public const ushort Shrubs01 = (Id << 8) | 1; // 0x0C01
                    /// <summary>Shrubs02 species</summary>
                    public const ushort Shrubs02 = (Id << 8) | 2; // 0x0C02
                    /// <summary>Shrubs03 species</summary>
                    public const ushort Shrubs03 = (Id << 8) | 3; // 0x0C03
                    /// <summary>Shrubs04 species</summary>
                    public const ushort Shrubs04 = (Id << 8) | 4; // 0x0C04
                    /// <summary>Shrubs05 species</summary>
                    public const ushort Shrubs05 = (Id << 8) | 5; // 0x0C05
                    /// <summary>Shrubs06 species</summary>
                    public const ushort Shrubs06 = (Id << 8) | 6; // 0x0C06
                    /// <summary>Shrubs07 species</summary>
                    public const ushort Shrubs07 = (Id << 8) | 7; // 0x0C07
                }
            }

            /// <summary>FumerolasGenus genus</summary>
            public static class Fumerolas
            {
                public const byte Id = 13;
                public static class Species
                {
                    /// <summary>Fumerolas01 species</summary>
                    public const ushort Fumerolas01 = (Id << 8) | 1; // 0x0D01
                    /// <summary>Fumerolas02 species</summary>
                    public const ushort Fumerolas02 = (Id << 8) | 2; // 0x0D02
                    /// <summary>Fumerolas03 species</summary>
                    public const ushort Fumerolas03 = (Id << 8) | 3; // 0x0D03
                    /// <summary>Fumerolas04 species</summary>
                    public const ushort Fumerolas04 = (Id << 8) | 4; // 0x0D04
                }
            }

            /// <summary>FungoidsGenus genus</summary>
            public static class Fungoids
            {
                public const byte Id = 14;
                public static class Species
                {
                    /// <summary>Fungoids01 species</summary>
                    public const ushort Fungoids01 = (Id << 8) | 1; // 0x0E01
                    /// <summary>Fungoids02 species</summary>
                    public const ushort Fungoids02 = (Id << 8) | 2; // 0x0E02
                    /// <summary>Fungoids03 species</summary>
                    public const ushort Fungoids03 = (Id << 8) | 3; // 0x0E03
                    /// <summary>Fungoids04 species</summary>
                    public const ushort Fungoids04 = (Id << 8) | 4; // 0x0E04
                }
            }

            /// <summary>OsseusGenus genus</summary>
            public static class Osseus
            {
                public const byte Id = 15;
                public static class Species
                {
                    /// <summary>Osseus01 species</summary>
                    public const ushort Osseus01 = (Id << 8) | 1; // 0x0F01
                    /// <summary>Osseus02 species</summary>
                    public const ushort Osseus02 = (Id << 8) | 2; // 0x0F02
                    /// <summary>Osseus03 species</summary>
                    public const ushort Osseus03 = (Id << 8) | 3; // 0x0F03
                    /// <summary>Osseus04 species</summary>
                    public const ushort Osseus04 = (Id << 8) | 4; // 0x0F04
                    /// <summary>Osseus05 species</summary>
                    public const ushort Osseus05 = (Id << 8) | 5; // 0x0F05
                    /// <summary>Osseus06 species</summary>
                    public const ushort Osseus06 = (Id << 8) | 6; // 0x0F06
                }
            }

            /// <summary>ReceptaGenus genus</summary>
            public static class Recepta
            {
                public const byte Id = 16;
                public static class Species
                {
                    /// <summary>Recepta01 species</summary>
                    public const ushort Recepta01 = (Id << 8) | 1; // 0x1001
                    /// <summary>Recepta02 species</summary>
                    public const ushort Recepta02 = (Id << 8) | 2; // 0x1002
                    /// <summary>Recepta03 species</summary>
                    public const ushort Recepta03 = (Id << 8) | 3; // 0x1003
                }
            }

            /// <summary>StratumGenus genus</summary>
            public static class Stratum
            {
                public const byte Id = 17;
                public static class Species
                {
                    /// <summary>Stratum01 species</summary>
                    public const ushort Stratum01 = (Id << 8) | 1; // 0x1101
                    /// <summary>Stratum02 species</summary>
                    public const ushort Stratum02 = (Id << 8) | 2; // 0x1102
                    /// <summary>Stratum03 species</summary>
                    public const ushort Stratum03 = (Id << 8) | 3; // 0x1103
                    /// <summary>Stratum04 species</summary>
                    public const ushort Stratum04 = (Id << 8) | 4; // 0x1104
                    /// <summary>Stratum05 species</summary>
                    public const ushort Stratum05 = (Id << 8) | 5; // 0x1105
                    /// <summary>Stratum06 species</summary>
                    public const ushort Stratum06 = (Id << 8) | 6; // 0x1106
                    /// <summary>Stratum07 species</summary>
                    public const ushort Stratum07 = (Id << 8) | 7; // 0x1107
                    /// <summary>Stratum08 species</summary>
                    public const ushort Stratum08 = (Id << 8) | 8; // 0x1108
                }
            }

            /// <summary>Tube genus</summary>
            public static class Tube
            {
                public const byte Id = 18;
                public static class Species
                {
                    /// <summary>Root species</summary>
                    public const ushort Root = (Id << 8) | 0; // 0x1200
                    /// <summary>TubeABCD01 species</summary>
                    public const ushort TubeABCD01 = (Id << 8) | 1; // 0x1201
                    /// <summary>TubeABCD02 species</summary>
                    public const ushort TubeABCD02 = (Id << 8) | 2; // 0x1202
                    /// <summary>TubeABCD03 species</summary>
                    public const ushort TubeABCD03 = (Id << 8) | 3; // 0x1203
                    /// <summary>TubeEFGH01 species</summary>
                    public const ushort TubeEFGH01 = (Id << 8) | 4; // 0x1204
                    /// <summary>TubeEFGH02 species</summary>
                    public const ushort TubeEFGH02 = (Id << 8) | 5; // 0x1205
                    /// <summary>TubeEFGH03 species</summary>
                    public const ushort TubeEFGH03 = (Id << 8) | 6; // 0x1206
                    /// <summary>TubeEFGH species</summary>
                    public const ushort TubeEFGH = (Id << 8) | 7; // 0x1207
                }
            }

            /// <summary>TubusGenus genus</summary>
            public static class Tubus
            {
                public const byte Id = 19;
                public static class Species
                {
                    /// <summary>Tubus01 species</summary>
                    public const ushort Tubus01 = (Id << 8) | 1; // 0x1301
                    /// <summary>Tubus02 species</summary>
                    public const ushort Tubus02 = (Id << 8) | 2; // 0x1302
                    /// <summary>Tubus03 species</summary>
                    public const ushort Tubus03 = (Id << 8) | 3; // 0x1303
                    /// <summary>Tubus04 species</summary>
                    public const ushort Tubus04 = (Id << 8) | 4; // 0x1304
                    /// <summary>Tubus05 species</summary>
                    public const ushort Tubus05 = (Id << 8) | 5; // 0x1305
                }
            }

            /// <summary>TussocksGenus genus</summary>
            public static class Tussocks
            {
                public const byte Id = 20;
                public static class Species
                {
                    /// <summary>Tussocks01 species</summary>
                    public const ushort Tussocks01 = (Id << 8) | 1; // 0x1401
                    /// <summary>Tussocks02 species</summary>
                    public const ushort Tussocks02 = (Id << 8) | 2; // 0x1402
                    /// <summary>Tussocks03 species</summary>
                    public const ushort Tussocks03 = (Id << 8) | 3; // 0x1403
                    /// <summary>Tussocks04 species</summary>
                    public const ushort Tussocks04 = (Id << 8) | 4; // 0x1404
                    /// <summary>Tussocks05 species</summary>
                    public const ushort Tussocks05 = (Id << 8) | 5; // 0x1405
                    /// <summary>Tussocks06 species</summary>
                    public const ushort Tussocks06 = (Id << 8) | 6; // 0x1406
                    /// <summary>Tussocks07 species</summary>
                    public const ushort Tussocks07 = (Id << 8) | 7; // 0x1407
                    /// <summary>Tussocks08 species</summary>
                    public const ushort Tussocks08 = (Id << 8) | 8; // 0x1408
                    /// <summary>Tussocks09 species</summary>
                    public const ushort Tussocks09 = (Id << 8) | 9; // 0x1409
                    /// <summary>Tussocks10 species</summary>
                    public const ushort Tussocks10 = (Id << 8) | 10; // 0x140A
                    /// <summary>Tussocks11 species</summary>
                    public const ushort Tussocks11 = (Id << 8) | 11; // 0x140B
                    /// <summary>Tussocks12 species</summary>
                    public const ushort Tussocks12 = (Id << 8) | 12; // 0x140C
                    /// <summary>Tussocks13 species</summary>
                    public const ushort Tussocks13 = (Id << 8) | 13; // 0x140D
                    /// <summary>Tussocks14 species</summary>
                    public const ushort Tussocks14 = (Id << 8) | 14; // 0x140E
                    /// <summary>Tussocks15 species</summary>
                    public const ushort Tussocks15 = (Id << 8) | 15; // 0x140F
                }
            }

        }
    }
}