using ExoScan.Enums;

namespace ExoScan.Helpers
{
    public class StarLuminosityHelper : EnumHelper<StarLuminosity>
    {
        private static readonly Dictionary<string, StarLuminosity> Mappings = new Dictionary<string, StarLuminosity>
        {
            { "0", StarLuminosity.O },
            { "Ia", StarLuminosity.Ia },
            { "Iab", StarLuminosity.Iab },
            { "Ib", StarLuminosity.Ib },
            { "II", StarLuminosity.II },
            { "III", StarLuminosity.III },
            { "IV", StarLuminosity.IV },
            { "V", StarLuminosity.V },
            { "VI", StarLuminosity.VI },
            { "VII", StarLuminosity.VII },
            { "I", StarLuminosity.I }
        };

        public StarLuminosityHelper() : base(Mappings) { }

        public static StarLuminosityHelper Instance { get; set; } = new StarLuminosityHelper();
        public static StarLuminosity GetLuminosity(string luminosity) => Instance.GetEnumValue(luminosity);
        public static string GetStarLuminosityName(StarLuminosity luminosity) => Instance.ToString(luminosity);
    }

}

