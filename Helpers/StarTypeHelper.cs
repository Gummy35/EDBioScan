using ExoScan.Enums;

namespace ExoScan.Helpers
{
    public class StarTypeHelper : EnumHelper<StarType>
    {
        private static readonly Dictionary<string, StarType> Mappings = new Dictionary<string, StarType>
        {
            { "O", StarType.O }, { "B", StarType.B }, { "A", StarType.A },
            { "F", StarType.F }, { "G", StarType.G }, { "K", StarType.K },
            { "M", StarType.M }, { "L", StarType.L }, { "T", StarType.T },
            { "Y", StarType.Y }, { "TTS", StarType.TTS }, { "AeBe", StarType.AeBe },
            { "W", StarType.W }, { "WN", StarType.WN }, { "WNC", StarType.WNC },
            { "WC", StarType.WC }, { "WO", StarType.WO }, { "MS", StarType.MS },
            { "S", StarType.S }, { "D", StarType.D }, { "N", StarType.N },
            { "H", StarType.H }, { "X", StarType.X }
        };

        public StarTypeHelper() : base(Mappings) { }

        public static readonly StarTypeHelper Instance = new StarTypeHelper();

        public static StarType GetStarType(string starType) => Instance.GetEnumValue(starType);
        public static string GetStarTypeName(StarType starType) => Instance.ToString(starType);
    }

}

