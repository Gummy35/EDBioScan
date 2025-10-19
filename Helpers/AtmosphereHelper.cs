using ExoScan.Enums;

namespace ExoScan.Helpers
{
    public class AtmosphereHelper : EnumHelper<Atmosphere>
    {
        private static readonly Dictionary<string, Atmosphere> Mappings = new Dictionary<string, Atmosphere>
        {
            { "None", Atmosphere.None },
            { "Ammonia", Atmosphere.Ammonia },
            { "Argon", Atmosphere.Argon },
            { "ArgonRich", Atmosphere.ArgonRich },
            { "CarbonDioxide", Atmosphere.CarbonDioxide },
            { "CarbonDioxideRich", Atmosphere.CarbonDioxideRich },
            { "Helium", Atmosphere.Helium },
            { "Methane", Atmosphere.Methane },
            { "MethaneRich", Atmosphere.MethaneRich },
            { "Neon", Atmosphere.Neon },
            { "NeonRich", Atmosphere.NeonRich },
            { "Nitrogen", Atmosphere.Nitrogen },
            { "Oxygen", Atmosphere.Oxygen },
            { "SulphurDioxide", Atmosphere.SulphurDioxide },
            { "Water", Atmosphere.Water },
            { "WaterRich", Atmosphere.WaterRich }
        };

        public AtmosphereHelper() : base(Mappings) { }

        public static readonly AtmosphereHelper Instance = new AtmosphereHelper();

        public static Atmosphere GetAtmosphere(string atmosphere) => Instance.GetEnumValue(atmosphere);
        public static string GetAtmosphereTypeName(Atmosphere atmosphere) => Instance.ToString(atmosphere);
        public static Atmosphere GetCombined(params string[] atmospheres) => Instance.GetCombinedEnumValue(atmospheres);
        public static List<string> ToList(Atmosphere atmosphere) => Instance.ToStringList(atmosphere);
    }

}

