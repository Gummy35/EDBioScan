using ExoScan.Enums;

namespace ExoScan.Helpers
{
    public class VolcanismHelper : EnumHelper<Volcanism>
    {
        private static readonly Dictionary<string, Volcanism> Mappings = new Dictionary<string, Volcanism>
        {
            { "carbon dioxide geysers", Volcanism.CarbonDioxideGeysers },
            { "carbon dioxide", Volcanism.CarbonDioxide },
            { "carbon", Volcanism.Carbon },
            { "methane", Volcanism.Methane },
            { "methane magma", Volcanism.MethaneMagma },
            { "nitrogen", Volcanism.Nitrogen },
            { "ammonia", Volcanism.Ammonia },
            { "water", Volcanism.Water },
            { "geysers", Volcanism.WaterGeysers },
            { "silicate", Volcanism.Silicate },
            { "major silicate", Volcanism.MajorSilicate },
            { "major silicate vapour", Volcanism.MajorSilicateVapour },
            { "rocky", Volcanism.Rocky },
            { "rocky magma", Volcanism.RockyMagma },
            { "major rocky", Volcanism.MajorRocky },
            { "major rocky magma", Volcanism.MajorRockyMagma },
            { "metallic", Volcanism.Metallic },
            { "metallic magma", Volcanism.MetallicMagma },
            { "major metallic", Volcanism.MajorMetallic },
            { "major metallic magma", Volcanism.MajorMetallicMagma }
        };

        public VolcanismHelper() : base(Mappings) { }

        public static readonly VolcanismHelper Instance = new VolcanismHelper();

        // Override for partial matching
        public override Volcanism GetEnumValue(string value)
        {
            if (string.IsNullOrEmpty(value))
                return Volcanism.None;

            // Try exact match first
            if (StringToEnum.TryGetValue(value, out var exact))
                return exact;

            // Try partial matches
            var result = Volcanism.None;
            foreach (var kvp in StringToEnum)
            {
                if (value.Contains(kvp.Key))
                    result |= kvp.Value;
            }
            return result;
        }

        public static Volcanism GetVolcanism(string volcanism) => Instance.GetEnumValue(volcanism);
        public static string GetVolcanismTypeName(Volcanism volcanism) => Instance.ToString(volcanism);
        public static Volcanism GetCombined(params string[] volcanisms) => Instance.GetCombinedEnumValue(volcanisms);
        public static List<string> ToList(Volcanism volcanism) => Instance.ToStringList(volcanism);
    }

}

