using ExoScan.Enums;

namespace ExoScan.StellarStructs
{
    public class ScanStatus
    {
        public string CommanderId { get; set; }
        public bool Discovered { get; set; } = false;
        public bool WasDiscovered { get; set; } = false;
        public bool Mapped { get; set; } = false;
        public bool WasMapped { get; set; } = false;
        public bool Efficient { get; set; } = false;
        public ScanType ScanState { get; set; } = 0;

        public static ScanStatus FindOrCreate(List<ScanStatus> statuses, string commanderId)
        {
            var status = statuses.FirstOrDefault(s => s.CommanderId == ExoData.CurrentCommander.FId, null);
            if (status == null)
            {
                status = new ScanStatus { CommanderId = ExoData.CurrentCommander.FId };
                statuses.Add(status);
            }
            return status;
        }
    }

    public static class ScannableBodyExtensions
    {
        /// <summary>
        /// Returns the ScanStatus of the current commander (default one if missing).
        /// </summary>
        public static ScanStatus GetStatus(this IScannableBody body, string commanderId = "default")
        {
            if (body.Statuses == null)
                body.Statuses = new List<ScanStatus>();

            return ScanStatus.FindOrCreate(body.Statuses, commanderId);
        }

        /// <summary>
        /// Returns a ScanStatus matching the provided parameters, creating it if necessary.
        /// </summary>
        public static ScanStatus GetStatus(
            this IScannableBody body,
            string commanderId,
            bool discovered,
            bool wasDiscovered,
            bool mapped,
            bool wasMapped,
            ScanType scanType)
        {
            var status = body.GetStatus(commanderId);
            status.Discovered = discovered;
            status.WasDiscovered = wasDiscovered;
            status.Mapped = mapped;
            status.WasMapped = wasMapped;
            status.ScanState = scanType;
            return status;
        }
    }
}
