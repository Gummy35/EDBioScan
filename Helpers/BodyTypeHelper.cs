using ExoScan.Enums;

namespace ExoScan.Helpers
{
    public class BodyTypeHelper : EnumHelper<PlanetType>
    {
        private static readonly Dictionary<string, PlanetType> Mappings = new Dictionary<string, PlanetType>
        {
            { "Icy body", PlanetType.IcyBody },
            { "Rocky body", PlanetType.RockyBody },
            { "Rocky ice body", PlanetType.RockyIceBody },
            { "High metal content body", PlanetType.HighMetalContentBody },
            { "Metal rich body", PlanetType.MetalRichBody },
            { "Earthlike body", PlanetType.EarthLikeBody },
            { "Sudarsky class I gas giant", PlanetType.ClassIGiant },
            { "Sudarsky class II gas giant", PlanetType.ClassIIGiant },
            { "Sudarsky class III gas giant", PlanetType.ClassIIIGiant },
            { "Sudarsky class IV gas giant", PlanetType.ClassIVGiant },
            { "Sudarsky class V gas giant", PlanetType.ClassVGiant },
            {"Gas giant with ammonia based life", PlanetType.GasGiantWithAmmoniaBasedLife },
            {"Gas giant with water based life", PlanetType.GasGiantWithWaterBasedLife },
            {"Helium rich gas giant", PlanetType.HeliumRichGasGiant }
        };

        public BodyTypeHelper() : base(Mappings) { }

        // Singleton instance
        public static readonly BodyTypeHelper Instance = new BodyTypeHelper();

        // Static convenience methods
        public static PlanetType GetBodyType(string bodyType) => Instance.GetEnumValue(bodyType, defaultValue: PlanetType.None);
        public static string GetBodyTypeName(PlanetType bodyType) => Instance.ToString(bodyType);
        public static PlanetType GetCombined(params string[] bodyTypes) => Instance.GetCombinedEnumValue(bodyTypes);
        public static List<string> ToList(PlanetType bodyType) => Instance.ToStringList(bodyType);
    }

}

