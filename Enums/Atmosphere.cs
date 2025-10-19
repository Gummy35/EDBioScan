namespace ExoScan.Enums
{
    [Flags]
    public enum Atmosphere
    {
        None = 1,
        Ammonia = 1 << 1,
        Argon = 1 << 2,
        ArgonRich = 1 << 3,
        CarbonDioxide = 1 << 4,
        CarbonDioxideRich = 1 << 5,
        Helium = 1 << 6,
        Methane = 1 << 7,
        MethaneRich = 1 << 8,
        Neon = 1 << 9,
        NeonRich = 1 << 10,
        Nitrogen = 1 << 11,
        Oxygen = 1 << 12,
        SulphurDioxide = 1 << 13,
        Water = 1 << 14,
        WaterRich = 1 << 15
    }

}

