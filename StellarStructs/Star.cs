using ExoScan.Enums;
using LiteDB;

namespace ExoScan.StellarStructs
{
    public class Star : IScannableBody
    {
        [BsonId]
        public ulong Id => (SystemId << 16) | (uint)BodyId;
        public ulong SystemId { get; set; }
        public int BodyId { get; set; }
        public string BodyName { get; set; }
        public string StarType { get; set; }
        public StarLuminosity Luminosity { get; set; }
        public Dictionary<int, BodyType> Parents { get; set; } = new();
        public double SurfaceTemperature { get; set; }
        public double SemiMajorAxis { get; set; }
        public double Radius { get; set; }
        public double DistanceFromArrivalLS { get; set; }
        public double Mass { get; set; }
        public int SubClass { get; set; }
        public double Rotation { get; set; }
        public double OrbitalPerion { get; set; }
        public Dictionary<string, string> Rings { get; set; } = new();
        public List<ScanStatus> Statuses { get; set; } = new();

    }
}
