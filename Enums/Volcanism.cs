namespace ExoScan.Enums
{
    [Flags]
    public enum Volcanism
    {
        None = 1,
        CarbonDioxideGeysers = 1 << 1,
        CarbonDioxide = 1 << 2,
        Carbon = 1 << 3,
        Methane = 1 << 4,
        MethaneGeysers = 1 << 5,
        MethaneMagma = 1 << 6,
        Nitrogen = 1 << 7,
        Ammonia = 1 << 8,
        Water = 1 << 9,
        WaterGeysers = 1 << 10,
        Silicate = 1 << 11,
        SilicateVapour = 1 << 12,
        MajorSilicate = 1 << 13,
        MajorSilicateVapour = 1 << 14,
        Rocky = 1 << 15,
        RockyMagma = 1 << 16,
        MajorRocky = 1 << 17,
        MajorRockyMagma = 1 << 18,
        Metallic = 1 << 19,
        MetallicMagma = 1 << 20,
        MajorMetallic = 1 << 21,
        MajorMetallicMagma = 1 << 22
    }

}

