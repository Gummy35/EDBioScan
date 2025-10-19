namespace ExoScan.Enums
{
    [Flags]
    public enum PlanetType
    {
        None = 1,
        IcyBody = 1 << 1,
        RockyBody = 1 << 2,
        RockyIceBody = 1 << 3,
        HighMetalContentBody = 1 << 4,
        MetalRichBody = 1 << 5,
        EarthLikeBody = 1 << 6,
        ClassIGiant = 1 << 7,
        ClassIIGiant = 1 << 8,
        ClassIIIGiant = 1 << 9,
        ClassIVGiant = 1 << 10,
        ClassVGiant = 1 << 11,
        GasGiantWithAmmoniaBasedLife = 1 << 12,
        GasGiantWithWaterBasedLife = 1 << 13,
        HeliumRichGasGiant = 1 << 14,
    }

}

