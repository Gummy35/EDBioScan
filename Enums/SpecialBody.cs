namespace ExoScan.Enums
{
    [Flags]
    public enum SpecialBody : int
    {
        None = 1,
        EarthlikeBody = 1 << 1,
        AmmoniaWorld = 1 << 2,
        WaterWorld = 1 << 3,
        GasGiantWithWaterBasedLife = 1 << 4,
        GasGiantWithAmmoniaBasedLife = 1 << 5,
        WaterGiant = 1 << 6
    }

}

