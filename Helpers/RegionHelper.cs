using ExoScan.Enums;
using ExoScan.StellarStructs;

namespace ExoScan.Helpers
{
    public class RegionHelper : EnumHelper<GalacticRegion>
    {
        private static readonly Dictionary<string, GalacticRegion> Mappings = new Dictionary<string, GalacticRegion>
        {
            { "orion-cygnus", GalacticRegion.OrionCygnus },
            { "orion-cygnus-1", GalacticRegion.OrionCygnus1 },
            { "orion-cygnus-core", GalacticRegion.OrionCygnusCore },
            { "sagittarius-carina", GalacticRegion.SagittariusCarina },
            { "sagittarius-carina-core", GalacticRegion.SagittariusCarinaCore },
            { "sagittarius-carina-core-9", GalacticRegion.SagittariusCarinaCore9 },
            { "perseus", GalacticRegion.Perseus },
            { "perseus-core", GalacticRegion.PerseusCore },
            { "scutum-centaurus", GalacticRegion.ScutumCentaurus },
            { "scutum-centaurus-core", GalacticRegion.ScutumCentaurusCore },
            { "outer", GalacticRegion.Outer },
            { "exterior", GalacticRegion.Exterior },
            { "anemone-a", GalacticRegion.AnemoneA },
            { "amphora", GalacticRegion.Amphora },
            { "brain-tree", GalacticRegion.BrainTree },
            { "empyrean-straits", GalacticRegion.EmpyreanStraits },
            { "center", GalacticRegion.Center },
        };

        public RegionHelper() : base(Mappings) { }

        public static readonly RegionHelper Instance = new RegionHelper();

        // Override to handle "!" prefix
        public override GalacticRegion GetEnumValue(string value)
        {
            if (string.IsNullOrEmpty(value))
                return GalacticRegion.Unknown;

            value = value.TrimStart('!');
            return base.GetEnumValue(value);
        }

        public static GalacticRegion GetRegion(string region) => Instance.GetEnumValue(region);
        public static string GetRegionName(GalacticRegion region) => Instance.ToString(region);

        public static (int sectorId, string sectorName) GetSector(Position position)
        {
            var x0 = -49985;
            var y0 = -40985;
            var z0 = -24105;

            int px = (int)((position.X - x0) * 83 / 4096);
            int pz = (int)((position.Z - z0) * 83 / 4096);

            if (px < 0 || pz < 0 || pz >= CodexData.RegionData.RegionMap.Length)
                return (0, null);

            try
            {
                var row = CodexData.RegionData.RegionMap[pz];
                int rx = 0;
                int pv = 0;

                foreach (var (rl, value) in row)
                {
                    if (px < rx + rl)
                    {
                        pv = value;
                        break;
                    }
                    rx += rl;
                }
                if (pv == 0)
                    return (0, null);

                return (pv, CodexData.RegionData.Regions[pv]);
            }
            catch (Exception e)
            {
                return (0, null);
            }
        }
    }

}

