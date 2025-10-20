using EliteAPI.Events;
using ExoScan.Enums;
using ExoScan.Helpers;
using LiteDB;
using System.Security.Cryptography;
using System.Text;

namespace ExoScan.StellarStructs
{
    public class StarSystem
    {
        public class Status
        {
            [BsonId]
            public ulong SystemId { get; set; } = 0;
            public string CommanderId { get; set; } = "";
            public bool Honked { get; set; } = false;
            public bool FullyScanned { get; set; } = false;
            public bool FullyMapped { get; set; } = false;
        }

        [BsonId]
        public ulong SystemId { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; } = new();
        public int? Region { get; set; }
        public int BodyCount { get; set; } = 1;
        public int NonBodyCount { get; set; } = 0;

        [BsonRef("statuses")]
        public List<Status> Statuses { get; set; } = new();
        //public Dictionary<int, PlanetData> Scans { get; set; } = new();
        public Dictionary<int, List<ScanResultEntry>> ScanResults { get; set; } = new();

        [BsonRef("planets")]
        public List<Planet> Planets { get; set; } = new();

        [BsonRef("stars")]
        public List<Star> Stars { get; set; } = new();

        [BsonRef("nonbodies")]
        public List<NonBody> NonBodies { get; set; } = new();
        public int LastBodyId { get; set; }
        public string LastBodyName { get; set; }

        private static BioForecast bioScanEvaluator = new BioForecast();

        public static ScanType GetScanType(string? scan)
        {
            if (scan == null) return 0;
            return scan switch
            {
                "NavBeacon" or "NavBeaconDetail" => ScanType.NavBeacon,
                "Basic" => ScanType.Basic,
                "AutoScan" or "Detailed" => ScanType.AutoOrDetailed,
                _ => ScanType.Unknown
            };
        }

        public StarSystem UpdateSystem(ulong? Address = null, string? Name = null, Position? Position = null)
        {
            if (Address != null) SystemId = Address.Value;
            if (Name != null) this.Name = Name;
            if (Position != null)
            {
                this.Position = Position;
                this.Region = RegionHelper.GetSector(Position).sectorId;
            }
            //            ExodataManager.Instance.Systems.Upsert(this);
            return this;
        }

        public string GetBodyName(string fullname)
        {
            if (fullname.StartsWith(Name + " ", StringComparison.Ordinal))
            {
                return fullname.Substring(Name.Length + 1);
            }
            return fullname;
        }

        public Status GetSystemStatus()
        {
            var statuses = Statuses.Where(s => s.CommanderId == ExoData.CurrentCommander.FId).ToList();
            if (statuses.Count > 0)
                return statuses[0];

            var status = new Status { SystemId = SystemId, CommanderId = ExoData.CurrentCommander.FId };
            Statuses.Add(status);
            //            ExodataManager.Instance.Systems.Upsert(this);
            ExoData.Statuses.Upsert(status);
            return status;

        }

        public Star GetStar(ScanEvent _event)
        {
            var scanType = GetScanType(_event.ScanType);
            var bodyShortName = GetBodyName(_event.BodyName);
            var bodyId = int.Parse(_event.BodyId);
            var star = GetStar(bodyId);
            star.BodyName = bodyShortName;
            star.DistanceFromArrivalLS = _event.DistanceFromArrivalLs;
            star.StarType = _event.StarType;
            star.Mass = _event.StellarMass;
            star.SubClass = _event.Subclass;
            star.Luminosity = StarLuminosityHelper.GetLuminosity(_event.Luminosity);
            star.Rotation = _event.RotationPeriod;
            star.OrbitalPerion = _event.OrbitalPeriod;

            if (ExoData.CurrentCommander != null)
            {
                star.GetStatus(
                    ExoData.CurrentCommander.FId,
                    true,
                    _event.WasDiscovered,
                    false,
                    _event.WasMapped,
                    scanType
                    );
            }

            var parentIds = star.Parents
                .Select(p => p.Key)
                .ToHashSet();
            if (_event.Parents != null)
            {
                star.Parents.Clear();
                foreach (var parent in _event.Parents)
                {
                    if (parent.Star != null && !parentIds.Contains((int)parent.Star))
                        star.Parents[(int)parent.Star] = BodyType.Star;
                    if (parent.Null != null && !parentIds.Contains((int)parent.Null))
                        star.Parents[(int)parent.Null] = BodyType.Barycenter;
                }
            }

            if (_event.Rings != null)
            {
                star.Rings.Clear();
                foreach (var ringInfo in _event.Rings)
                {
                    var ringName = ringInfo.Name;
                    var nameOnly = ringName.Length > _event.BodyName.Length + 1 ? ringName.Substring(_event.BodyName.Length + 1) : ringName;
                    star.Rings[nameOnly] = ringInfo.RingClass;
                }
            }
            ExoData.Stars.Upsert(star);
            return star;
        }

        public Star GetStar(int bodyId)
        {
            var starData = Stars.Find(s => s.BodyId == bodyId);
            if (starData == null)
            {
                starData = new Star() { BodyId = bodyId, SystemId = this.SystemId };
                Stars.Add(starData);
            }
            return starData;
        }

        public Planet GetPlanet(int bodyId)
        {
            var planet = Planets.Find(s => s.BodyId == bodyId);
            if (planet == null)
            {
                planet = new Planet() { BodyId = bodyId, SystemId = this.SystemId };
                Planets.Add(planet);
            }
            return planet;
        }

        public NonBody GetNonBody(int bodyId)
        {
            var bary = NonBodies.Find(s => s.BodyId == bodyId);
            if (bary == null)
            {
                bary = new NonBody() { BodyId = bodyId, SystemId = this.SystemId };
                NonBodies.Add(bary);
            }
            return bary;
        }

        public Planet GetPlanet(ScanEvent _event)
        {
            var bodyId = int.Parse(_event.BodyId);
            var scanType = GetScanType(_event.ScanType);
            var bodyShortName = GetBodyName(_event.BodyName);

            LastBodyId = bodyId;
            LastBodyName = bodyShortName;

            var planet = GetPlanet(bodyId);
            planet.Name = bodyShortName;
            planet.DistanceFromArrivalLS = _event.DistanceFromArrivalLs;
            planet.BodyType = BodyTypeHelper.GetBodyType(_event.PlanetClass);
            planet.SpecialBodyType = SpecialBodyHelper.GetSpecialBody(_event.PlanetClass);

            planet.Mass = _event.MassEm;
            planet.Gravity = _event.SurfaceGravity;
            planet.Temperature = _event.SurfaceTemperature;
            planet.Pressure = _event.SurfacePressure;
            planet.Radius = _event.Radius;
            planet.Volcanism = _event.Volcanism;
            planet.Rotation = _event.RotationPeriod;
            planet.OrbitalPeriod = _event.OrbitalPeriod;
            planet.Landable = _event.IsLandable;
            planet.TerraformState = _event.TerraformState;

            if (ExoData.CurrentCommander != null)
            {
                var status = planet.GetStatus(ExoData.CurrentCommander.FId);
                status.Discovered = true;
                status.WasDiscovered = _event.WasDiscovered;
                status.WasMapped = _event.WasMapped;
                status.ScanState = scanType;
                // this is a detailed scan, and a fsscompletescan was done on it
                if (scanType == ScanType.AutoOrDetailed && status.Mapped)
                {
                    if (planet.BioSignals == null && planet.Floras.Count == 0)
                        planet.BioSignals = 0;

                    if (planet.GeoSignals == null)
                        planet.GeoSignals = 0;
                }
                if (planet.BioSignals == 0 && ScanResults.ContainsKey(planet.BodyId))
                {
                    ScanResults.Remove(planet.BodyId);
                }
            }

            var parentIds = planet.Parents
                .Select(p => p.Key)
                .ToHashSet();
            foreach (var parent in _event.Parents)
            {
                if (parent.Star != null && !parentIds.Contains((int)parent.Star))
                    planet.Parents[(int)parent.Star] = BodyType.Star;
                if (parent.Planet != null && !parentIds.Contains((int)parent.Planet))
                    planet.Parents[(int)parent.Planet] = BodyType.Planet;
                if (parent.Null != null && !parentIds.Contains((int)parent.Null))
                    planet.Parents[(int)parent.Null] = BodyType.Barycenter;
            }

            if (_event.Materials != null)
                foreach (var material in _event.Materials)
                    planet.Materials[material.Name] = material.Percent;

            planet.Atmosphere = AtmosphereHelper.GetAtmosphere(_event.AtmosphereType);
            if (_event.AtmosphereComposition != null)
                foreach (var atmoElement in _event.AtmosphereComposition)
                    planet.AtmosphereComposition[atmoElement.Name] = atmoElement.Percent;

            if (_event.Rings != null)
            {
                planet.Rings.Clear();
                foreach (var ringInfo in _event.Rings)
                {
                    var ringName = ringInfo.Name;
                    var nameOnly = ringName.Length > _event.BodyName.Length + 1 ? ringName.Substring(_event.BodyName.Length + 1) : ringName;
                    planet.Rings[nameOnly] = ringInfo.RingClass;
                }
            }
            ExoData.Planets.Upsert(planet);
            return planet;
        }

        public NonBody GetNonBody(ScanBaryCentreEvent _event)
        {
            var bodyId = int.Parse(_event.BodyId);
            var scanType = ScanType.Basic;
            var nonBody = GetNonBody(bodyId);

            if (ExoData.CurrentCommander != null)
            {
                nonBody.GetStatus(
                    ExoData.CurrentCommander.FId,
                    true,
                    false,
                    false,
                    false,
                    scanType
                );
            }

            ExoData.NonBodies.Upsert(nonBody);
            return nonBody;
        }

        public NonBody GetNonBody(ScanEvent _event)
        {
            var bodyId = int.Parse(_event.BodyId);
            var scanType = ScanType.Basic;
            var nonBody = GetNonBody(bodyId);

            if (ExoData.CurrentCommander != null)
            {
                nonBody.GetStatus(
                    ExoData.CurrentCommander.FId,
                    true,
                    false,
                    false,
                    false,
                    scanType
                );
            }

            ExoData.NonBodies.Upsert(nonBody);
            return nonBody;
        }

        public void UpdateSystem(FssDiscoveryScanEvent data)
        {
            var status = GetSystemStatus();
            status.Honked = true;
            BodyCount = (int)data.BodyCount;
            NonBodyCount = (int)data.NonBodyCount;
            if (data.Progress == 1.0)
                status.FullyScanned = true;
        }

        // Build a SHA256 hash for the entire structure
        public string GetScanResultsHash(int? bodyId = null)
        {
            var sb = new StringBuilder();

            if (bodyId != null)
            {
                sb.Append(bodyId).Append(':');
                if (ScanResults.TryGetValue(bodyId.Value, out var list))
                {
                    foreach (var r in list.OrderBy(e => e.Name).ThenBy(e => e.Value))
                    {
                        sb.Append($"{r.GetHash()};");
                    }
                }
            }
            else
            {
                foreach (var (key, list) in ScanResults.OrderBy(k => k.Key))
                {
                    sb.Append(key).Append(':');
                    foreach (var r in list.OrderBy(e => e.Name).ThenBy(e => e.Value))
                    {
                        sb.Append($"{r.GetHash()};");
                    }
                }
            }
            if (sb.Length > 0)
            {
                using var sha = SHA256.Create();
                var hashBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(sb.ToString()));
                return Convert.ToBase64String(hashBytes);
            }
            else return "";
        }

        public Dictionary<int, List<ScanResultEntry>> UpdateScanResults(int? bodyId, out bool hasChanges)
        {
            bioScanEvaluator.SetSystem(this);
            List<Planet> planetList;
            hasChanges = false;
            if (bodyId == null)
            {
                planetList = Planets;
            }
            else
            {
                planetList = Planets.Where(p => p.BodyId == bodyId).ToList();
                bioScanEvaluator.InvalidateCache(bodyId.Value);
            }

            foreach (var p in planetList)
            {
                var currentHash = GetScanResultsHash(p.BodyId);
                var planetRes = bioScanEvaluator.GetPossibleValues(p);
                var results = new List<ScanResultEntry>();
                if (planetRes.Count > 0)
                {
                    foreach (var res in planetRes)
                    {
                        var planetEntries = ScanResultEntry.GetEntries(p, res);
                        results.AddRange(planetEntries);
                    }
                    ScanResults[p.BodyId] = results;
                }
                else
                {
                    if (ScanResults.ContainsKey(p.BodyId) && ScanResults[p.BodyId].Count > 0)
                    {
                        ScanResults.Remove(p.BodyId);
                    }
                }
                var newHash = GetScanResultsHash(p.BodyId);
                if (currentHash != newHash)
                {
                    hasChanges = true;
                    ExoData.Planets.Upsert(p);
                }
            }

            if (hasChanges)
            {
                ExoData.Systems.Upsert(this);
            }

            return ScanResults;
        }

        public void Save()
        {
            var deleteCount = 0;
            // delete orphans

            foreach (var p in this.Planets.ToList())
                if (p.SystemId == 0)
                    this.Planets.Remove(p);
            foreach (var p in this.Planets)
                ExoData.Planets.Upsert(p);
            foreach (var p in this.Stars.ToList())
                if (p.SystemId == 0)
                    this.Stars.Remove(p);
            foreach (var s in this.Stars)
                ExoData.Stars.Upsert(s);
            foreach (var p in this.NonBodies.ToList())
                if (p.SystemId == 0)
                    this.NonBodies.Remove(p);
            foreach (var n in this.NonBodies)
                ExoData.NonBodies.Upsert(n);
            foreach (var p in this.Statuses.ToList())
                if (p.SystemId == 0)
                    this.Statuses.Remove(p);
            foreach (var st in this.Statuses)
                ExoData.Statuses.Upsert(st);
            ExoData.Systems.Upsert(this);

            deleteCount = ExoData.Planets.DeleteMany(p => p.SystemId == 0);
            deleteCount += ExoData.Stars.DeleteMany(p => p.SystemId == 0);
            deleteCount += ExoData.NonBodies.DeleteMany(p => p.SystemId == 0);
        }
    }
}
