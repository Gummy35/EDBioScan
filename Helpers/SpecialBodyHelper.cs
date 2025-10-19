using ExoScan.Enums;

namespace ExoScan.Helpers
{
    public class SpecialBodyHelper : EnumHelper<SpecialBody>
    {
        private static readonly Dictionary<string, SpecialBody> Mappings = new Dictionary<string, SpecialBody>
        {
            { "Earthlike body", SpecialBody.EarthlikeBody },
            { "Ammonia world", SpecialBody.AmmoniaWorld },
            { "Water world", SpecialBody.WaterWorld },
            { "Gas giant with water based life", SpecialBody.GasGiantWithWaterBasedLife },
            { "Gas giant with ammonia based life", SpecialBody.GasGiantWithAmmoniaBasedLife },
            { "Water giant", SpecialBody.WaterGiant }
        };

        public SpecialBodyHelper() : base(Mappings) { }

        public static readonly SpecialBodyHelper Instance = new SpecialBodyHelper();

        public static SpecialBody GetSpecialBody(string body) => Instance.GetEnumValue(body, defaultValue: SpecialBody.None);
        public static string GetSpecialBodyName(SpecialBody body) => Instance.ToString(body);
        public static SpecialBody GetCombined(params string[] bodies) => Instance.GetCombinedEnumValue(bodies);
        public static List<string> ToList(SpecialBody body) => Instance.ToStringList(body);
    }

}

