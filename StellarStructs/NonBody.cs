using LiteDB;

namespace ExoScan.StellarStructs
{
    public class NonBody : IScannableBody
    {
        [BsonId]
        public ulong Id => (SystemId << 16) | (uint)BodyId;
        public ulong SystemId { get; set; }
        public int BodyId { get; set; }
        public List<ScanStatus> Statuses { get; set; } = new();
    }
}
