using EliteAPI.Events;
using ExoScan.CodexData;
using ExoScan.Enums;
using LiteDB;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan.StellarStructs
{

    public class Planet : IScannableBody
    {
        public class Flora
        {
            public class WayPoint
            {
                public double Latitude { get; set; }
                public double Longitude { get; set; }
                public string Type { get; set; } = "tag";
            }
            public class Scan
            {
                public string CommanderId { get; set; }
                public BioScanType ScanType { get; set; }
                public List<WayPoint> WayPoints { get; set; } = new();
            }
            public GenusEnum Genus { get; set; }
            public int Species { get; set; }
            public string Color { get; set; }
            public List<Scan> Scans { get; set; } = new();
        }

        [BsonId]
        public ulong Id => (SystemId << 16) | (uint)BodyId;
        public ulong SystemId { get; set; }
        public int BodyId { get; set; }
        public string Name { get; set; }
        public PlanetType BodyType { get; set; } = PlanetType.None;
        public SpecialBody SpecialBodyType { get; set; } = SpecialBody.None;
        public Atmosphere Atmosphere { get; set; } = Atmosphere.None;
        public string Volcanism { get; set; } = "";
        public double DistanceFromArrivalLS { get; set; } = 0;
        public double Mass { get; set; } = 0;
        public double Rotation { get; set; } = 0;
        public double OrbitalPeriod { get; set; } = 0;
        public double Gravity { get; set; } = 0;
        public double Temperature { get; set; }
        public double Pressure { get; set; }
        public double Radius { get; set; } = 0;
        public Dictionary<int, BodyType> Parents { get; set; } = new();
        public int? BioSignals { get; set; } = null;
        public int? GeoSignals { get; set; } = null;
        public Dictionary<string, double> Materials { get; set; } = new();
        public bool Landable { get; set; } = false;
        public string TerraformState = "";
        public List<ScanStatus> Statuses { get; set; } = new();
        public Dictionary<string, double> AtmosphereComposition { get; set; } = new();
        public Dictionary<GenusEnum, Flora> Floras { get; set; } = new();
        //public List<Geo> Geos { get; set; } = new();
        public Dictionary<string, string> Rings { get; set; } = new();


        public List<Star> GetParentStars()
        {
            var parentIds = Parents
                .Where(p => p.Value == Enums.BodyType.Star)
                .Select(p => p.Key)
                .ToHashSet();

            return ExoData.CurrentSystem.Stars
                .Where(s => parentIds.Contains(s.BodyId) && s.StarType != null)
                .ToList();
        }

        public void AddSignals(FssBodySignalsEvent _event)
        {
            //var bodyShortName = GetBodyName(GetStringOrDefault(entry, "BodyName"));
            //if (bodyShortName.EndsWith("Ring", StringComparison.Ordinal) || bodyShortName.Contains("Belt Cluster"))
            //    return;

            //var bodyData = PlanetData.FromJournal(_system, bodyShortName, GetIntOrDefault(entry, "BodyID"), _session);

            foreach (var signal in _event.Signals)
            {
                if (signal.Type == "$SAA_SignalType_Biological;")
                    BioSignals = (int)signal.Count;
                else if (signal.Type == "$SAA_SignalType_Geological;")
                    GeoSignals = (int)signal.Count;
            }
        }

        public void AddSignals(SaaSignalsFoundEvent _event)
        {
            foreach (var signal in _event.Signals)
            {
                if (signal.Type.Symbol == "$SAA_SignalType_Biological;")
                    BioSignals = (int)signal.Count;
                else if (signal.Type.Symbol == "$SAA_SignalType_Geological;")
                    GeoSignals = (int)signal.Count;
            }

            foreach (var genus in _event.Genuses)
            {
                if (CodexMap.TryGenusFromString(genus.Name.Symbol, out var g))
                    if (!Floras.ContainsKey(g))
                        Floras.Add(g, new Flora() { Genus = g });
            }
        }

        private Flora GetFlora(GenusEnum genus, int species)
        {
            if (!Floras.ContainsKey(genus))
                Floras.Add(genus, new Flora() { Genus = genus });
            Floras[genus].Species = species;
            return Floras[genus];
        }

        public void SetFloraColor(GenusEnum genus, int species, string color)
        {
            var flora = GetFlora(genus, species);
            flora.Color = color;
        }

        private void SetFloraSpeciesScan(GenusEnum genus, int species, BioScanType scanType, Commander? commander = null)
        {
            commander = commander ?? ExoData.CurrentCommander;
            var flora = GetFlora(genus, species);
            var scan = flora.Scans.FirstOrDefault(s => s.CommanderId == commander.FId, null);
            if (scan == null)
            {
                scan = new Flora.Scan() { CommanderId = commander.FId };
                flora.Scans.Add(scan);
            }
            scan.ScanType = scanType;
            if (scanType == BioScanType.Analyse)
                scan.WayPoints.Clear();
        }

        private void AddFloraWayPoint(GenusEnum genus, int species, (float latitude, float longitude) latlong, Commander commander, bool isScan = false)
        {
            var flora = GetFlora(genus, species);
            var scan = flora.Scans.FirstOrDefault(s => s.CommanderId != commander.FId, null);
            if (scan == null || scan.ScanType != BioScanType.Analyse)
            {
                if (scan == null)
                {
                    scan = new Flora.Scan() { CommanderId = commander.FId };
                    flora.Scans.Add(scan);
                }

                var waypoint = new Flora.WayPoint()
                {
                    Latitude = latlong.latitude,
                    Longitude = latlong.longitude,
                };
                if (isScan) waypoint.Type = "scan";
                scan.WayPoints.Add(waypoint);
            }
        }

        private bool HasWaypoint(Commander commander)
        {
            return Floras.Values
    .SelectMany(f => f.Scans)
    .Where(s => s.CommanderId == commander.FId)
    .Any(s => s.WayPoints.Any(wp => wp.Type == "tag"));
        }

        public static BioScanType GetBioScanType(string? scan)
        {
            if (scan == null) return 0;
            return scan switch
            {
                "Log" => BioScanType.Log,
                "Sample" => BioScanType.Sample,
                "Analyse" => BioScanType.Analyse,
                _ => BioScanType.Unknown
            };
        }


        public void AddScan(ScanOrganicEvent _event)
        {
            var scanType = GetBioScanType(_event.ScanType);
            if (CodexMap.TryGenusFromString(_event.Genus.Symbol, out var g))
            {
                if (CodexMap.TryFromString(_event.Species.Symbol, out var s))
                {
                    SetFloraSpeciesScan(g, s, scanType);

                    if (!string.IsNullOrEmpty(_event.Variant.Symbol))
                    {
                        if (CodexMap.ParseVariant(_event.Variant.Symbol, out var variantData))
                            SetFloraColor(variantData.genus.Value, variantData.species, variantData.variant);
                    }
                }
            }
        }
    }
}
