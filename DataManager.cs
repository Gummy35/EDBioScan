using EliteAPI.Abstractions;
using EliteAPI.Abstractions.Events;
using EliteAPI.Events;
using ExoScan.CodexData;
using ExoScan.StellarStructs;
using LiteDB;
using System.Text.RegularExpressions;
namespace ExoScan
{
    public sealed class DataManager
    {
        private IEliteDangerousApi EliteAPI;

        private readonly LiteDatabase _db;
        private readonly Dictionary<ulong, StarSystem> _systemCache = new();

        public StarSystem CurrentSystem { get; private set; } = new();
        public Commander CurrentCommander { get; private set; } = new();

        public ILiteCollection<StarSystem> Systems { get; }
        public ILiteCollection<Planet> Planets { get; }
        public ILiteCollection<Star> Stars { get; }
        public ILiteCollection<NonBody> NonBodies { get; }
        public ILiteCollection<StarSystem.Status> Statuses { get; }
        public ILiteCollection<Commander> Commanders { get; }


        /// <summary>
        ///         void UpdateExoData(ulong SystemAddress, int? bodyId, DateTime timestamp)
        /// </summary>
        public event Action<StarSystem, int?, DateTime>? ExoDataUpdateHandler;
        public event Action<string> OnLog;

        private static readonly Dictionary<string, Type> EventTypeMap = new()
        {
            ["Scan"] = typeof(ScanEvent),
            ["ScanBaryCentre"] = typeof(ScanBaryCentreEvent),
            ["FSSBodySignals"] = typeof(FssBodySignalsEvent),
            ["SAASignalsFound"] = typeof(SaaSignalsFoundEvent),
            ["ScanOrganic"] = typeof(ScanOrganicEvent),
            ["FSDJump"] = typeof(FsdJumpEvent),
            ["Location"] = typeof(LocationEvent),
            ["CarrierJump"] = typeof(CarrierJumpEvent),
            ["FSSDiscoveryScan"] = typeof(FssDiscoveryScanEvent),
            ["FSSAllBodiesFound"] = typeof(FssAllBodiesFoundEvent),
            ["SAAScanComplete"] = typeof(SaaScanCompleteEvent),
            ["LoadGame"] = typeof(LoadGameEvent),
            ["Commander"] = typeof(CommanderEvent),
            ["NewCommander"] = typeof(NewCommanderEvent),
            ["CodexEntry"] = typeof(CodexEntryEvent)
        };

        // Singleton
        private static readonly Lazy<DataManager> _instance = new(() => new DataManager());
        public static DataManager ExoData => _instance.Value;

        private DataManager()
        {
            _db = new LiteDatabase("scans.db");
            Systems = _db.GetCollection<StellarStructs.StarSystem>("systems");
            Planets = _db.GetCollection<StellarStructs.Planet>("planets");
            Stars = _db.GetCollection<StellarStructs.Star>("stars");
            NonBodies = _db.GetCollection<StellarStructs.NonBody>("nonbodies");
            Statuses = _db.GetCollection<StellarStructs.StarSystem.Status>("statuses");
            // ScanResults = scanDb.GetCollection<ScanResultEntry>("scanresults");
            Commanders = _db.GetCollection<Commander>("commanders");
            Commanders.EnsureIndex(x => x.FId);
            Systems.EnsureIndex(x => x.Position.X);
            Systems.EnsureIndex(x => x.Position.Y);
            Systems.EnsureIndex(x => x.Position.Z);
            Planets.EnsureIndex(x => x.SystemId);
            Planets.EnsureIndex(x => x.BodyId);
            Stars.EnsureIndex(x => x.SystemId);
            Stars.EnsureIndex(x => x.BodyId);
            NonBodies.EnsureIndex(x => x.SystemId);
            NonBodies.EnsureIndex(x => x.BodyId);

            _db.Checkpoint();
        }

        public void SetEliteAPIInstance(IEliteDangerousApi eliteAPI)
        {
            EliteAPI = eliteAPI;
        }

        public void SetCmdr(string FId, string name)
        {
            CurrentCommander = Commanders.FindOne(x => x.FId == FId);
            if (CurrentCommander == null)
            {
                CurrentCommander = new Commander { FId = FId, Name = name };
                Commanders.Upsert(CurrentCommander);
            }
        }

        public StarSystem GetSystem(ulong systemAddress)
        {
            if (CurrentSystem.SystemId == systemAddress)
                return CurrentSystem;

            // If the requested system is not the current system, save the current system to db
            if (CurrentSystem != null && CurrentSystem.SystemId != 0)
                CurrentSystem.Save();

            // search system in cache
            if (!_systemCache.TryGetValue(systemAddress, out var system))
            {
                // if not found, try db. Otherwise, create it
                system = Systems
                    .Include(x => x.Statuses)
                    .Include(x => x.NonBodies)
                    .Include(x => x.Planets)
                    .Include(x => x.Stars)
                    .FindById(systemAddress) ?? new StarSystem { SystemId = systemAddress };
                _systemCache[systemAddress] = system;
            }

            // sets as the new current system
            CurrentSystem = system;
            // force save the new system, to ensure cleanup and data upgrades
            CurrentSystem.Save();
            return CurrentSystem;

        }

        public void Cleanup()
        {
            foreach (var key in _systemCache
                         .Where(kv => string.IsNullOrEmpty(kv.Value.Name))
                         .Select(kv => kv.Key)
                         .ToList())
                _systemCache.Remove(key);

            CurrentSystem.Save();
            _db.Checkpoint();
        }


        public IEnumerable<StarSystem> GetSystemsInRange(Position currentPosition, double range)
        {
            _systemCache.Clear();
            IEnumerable<ExoScan.StellarStructs.StarSystem> systems;
            if (currentPosition != null)
            {
                var candidates = Systems.Find(x =>
                    x.Position.X >= currentPosition.X - range && x.Position.X <= currentPosition.X + range &&
                    x.Position.Y >= currentPosition.Y - range && x.Position.Y <= currentPosition.Y + range &&
                    x.Position.Z >= currentPosition.Z - range && x.Position.Z <= currentPosition.Z + range
                );
                var range2 = range * range;

                systems = candidates.Where(s =>
                {
                    double dx = s.Position.X - currentPosition.X;
                    double dy = s.Position.Y - currentPosition.Y;
                    double dz = s.Position.Z - currentPosition.Z;

                    double distSq = dx * dx + dy * dy + dz * dz;
                    return distSq <= range2;
                });
            }
            else
            {
                systems = Systems.FindAll();
            }

            foreach (var system in systems)
            {
                _systemCache.Add(system.SystemId, system);
            }

            return systems;
        }

        #region EliteAPI events processing

        public void HandleScanBaryCentre(ScanBaryCentreEvent data)
        {
            if (CurrentSystem == null)
                GetSystem(ulong.Parse(data.SystemAddress));

            CurrentSystem.GetNonBody(data);
        }

        public void HandleCodexEntry(CodexEntryEvent data)
        {
            if (data.Category.Symbol == "$Codex_Category_Biology;" && !string.IsNullOrEmpty(data.BodyID))
            {
                var currentSystem = CurrentSystem;
                var planet = currentSystem.GetPlanet(int.Parse(data.BodyID));
                if (planet != null)
                {
                    if (data.SubCategory.Symbol == "$Codex_SubCategory_Geology_and_Anomalies;")
                    {
                        //planet.AddGeo(data.Name);
                    }
                    else if (data.SubCategory.Symbol == "$Codex_SubCategory_Organic_Structures;")
                    {
                        if (CodexMap.ParseVariant(data.Name.Symbol, out var variantData))
                            planet.SetFloraColor(variantData.genus.Value, variantData.species, variantData.variant);
                    }
                    // set_codex(self._cmdr.id, entry['Name'], self._system.region)
                }
            }
        }

        public void HandleSaaScanComplete(SaaScanCompleteEvent data)
        {
            var currentSystem = CurrentSystem;
            var bodyShortName = currentSystem.GetBodyName(data.BodyName);
            if (bodyShortName.EndsWith("Ring") || bodyShortName.Contains("Belt Cluster"))
            {
                //   var nonBody = currentSystem.GetNonBody(data.BodyId);
            }
            else
            {
                var body = currentSystem.GetPlanet(int.Parse(data.BodyId));
                var target = data.EfficiencyTarget;
                var used = data.ProbesUsed;
                var status = body.GetStatus();
                status.Mapped = true;
                status.Efficient = target >= used;
                int count = 0;
                var systemStatus = currentSystem.GetSystemStatus();
                if (systemStatus.FullyScanned)
                {
                    count = 0;
                    foreach (var planet in currentSystem.Planets)
                    {
                        var planetStatus = planet.GetStatus();
                        if (planetStatus.Mapped)
                            count++;
                    }
                    if (count == currentSystem.Planets.Count)
                    {
                        systemStatus.FullyMapped = true;
                    }
                }
            }
        }

        public void HandleFssAllBodiesFound(FssAllBodiesFoundEvent data)
        {
            var currentSystem = CurrentSystem;
            currentSystem.GetSystemStatus().FullyScanned = true;
        }

        public void HandleFssDiscoveryScan(FssDiscoveryScanEvent data)
        {
            var currentSystem = CurrentSystem;
            currentSystem.UpdateSystem(data);
        }

        public void HandleCarrierJump(CarrierJumpEvent data)
        {
            var system = GetSystem(ulong.Parse(data.SystemAddress));
            system.UpdateSystem(Name: data.StarSystem, Position: new Position(data.StarPos));

        }

        public void HandleNewCommander(NewCommanderEvent data)
        {
            SetCmdr(data.FrontierId, data.Name);
        }

        public void HandleCommander(CommanderEvent data)
        {
            SetCmdr(data.Fid, data.Name);
        }

        public void HandleLoadGame(LoadGameEvent data)
        {
            SetCmdr(data.Fid, data.Commander);
        }

        public void HandleScanOrganic(ScanOrganicEvent data)
        {
            var bodyId = (int)data.Body;
            var systemAddress = ulong.Parse(data.SystemAddress);
            var currentSystem = GetSystem(systemAddress);
            currentSystem.GetPlanet(bodyId).AddScan(data);
            //            ExodataManager.Instance.AddOrganicScan(systemAddress, bodyId, data.Genus.Symbol);            
            ExoDataUpdateHandler?.Invoke(currentSystem, bodyId, data.Timestamp);
        }

        public void HandleFssBodySignals(FssBodySignalsEvent data)
        {
            var currentSystem = CurrentSystem;
            int bodyId = int.Parse(data.BodyId);
            foreach (var signal in data.Signals)
            {
                var planet = currentSystem.GetPlanet(bodyId);
                planet.AddSignals(data);
                //                    theCount = signal.Count;
            }
            //var scan = currentSystem.GetBodyScan(bodyId);
            //scan.BioSignals = (int)theCount;
            //if (currentSystem.BioScans.ContainsKey(bodyId))
            //    currentSystem.BioScans[bodyId] = scan.BioSignals;
            //else
            //    currentSystem.BioScans.Add(bodyId, scan.BioSignals);
        }

        public void HandleSaaSignalsFound(SaaSignalsFoundEvent data)
        {
            var currentSystem = CurrentSystem;
            int bodyId = int.Parse(data.BodyId);
            var planet = currentSystem.GetPlanet(bodyId);
            planet.AddSignals(data);
            //            Systems.Upsert(currentSystem);
            ExoDataUpdateHandler?.Invoke(currentSystem, bodyId, data.Timestamp);
        }

        public void HandleScan(ScanEvent data)
        {
            if (CurrentSystem == null)
                GetSystem(ulong.Parse(data.SystemAddress));
            if (!string.IsNullOrEmpty(data.StarType))
            {
                CurrentSystem.GetStar(data);
            }
            else if (!string.IsNullOrEmpty(data.PlanetClass))
            {
                CurrentSystem.GetPlanet(data);
            }
            else
            {
                CurrentSystem.GetNonBody(data);
            }
            ExoDataUpdateHandler?.Invoke(CurrentSystem, null, data.Timestamp);
        }

        public void HandleFsdJump(FsdJumpEvent fsdJumpdataData)
        {
            var system = GetSystem(ulong.Parse(fsdJumpdataData.SystemAddress));
            system.UpdateSystem(Name: fsdJumpdataData.StarSystem, Position: new Position(fsdJumpdataData.StarPos));
        }

        public void HandleLocation(LocationEvent data)
        {
            var system = GetSystem(ulong.Parse(data.SystemAddress));
            system.UpdateSystem(Name: data.StarSystem, Position: new Position(data.StarPos));
        }



        public void HandleEliteApiEvent(IEvent eventData, EventContext context)
        {
            if (!context.IsRaisedDuringCatchup)
            {
                switch (eventData)
                {
                    case ScanEvent e: HandleScan(e); break;
                    case ScanBaryCentreEvent e: HandleScanBaryCentre(e); break;
                    case FssBodySignalsEvent e: HandleFssBodySignals(e); break;
                    case SaaSignalsFoundEvent e: HandleSaaSignalsFound(e); break;
                    case ScanOrganicEvent e: HandleScanOrganic(e); break;
                    case LocationEvent e: HandleLocation(e); break;
                    case FsdJumpEvent e: HandleFsdJump(e); break;
                    case CarrierJumpEvent e: HandleCarrierJump(e); break;
                    case FssDiscoveryScanEvent e: HandleFssDiscoveryScan(e); break;
                    case FssAllBodiesFoundEvent e: HandleFssAllBodiesFound(e); break;
                    case SaaScanCompleteEvent e: HandleSaaScanComplete(e); break;
                    case LoadGameEvent e: HandleLoadGame(e); break;
                    case CommanderEvent e: HandleCommander(e); break;
                    case NewCommanderEvent e: HandleNewCommander(e); break;
                    case CodexEntryEvent e: HandleCodexEntry(e); break;
                    default:
                        break;
                }
            }
        }

        public void ImportAllJournals()
        {
            var path = EliteAPI.Config.JournalsPath;
            var pattern = EliteAPI.Config.JournalPattern;
            var files = Directory.GetFiles(path, pattern)
                                 .OrderBy(f => f)
                                 .ToList();

            foreach (var file in files)
            {
                var context = new EventContext() { IsImplemented = true, IsRaisedDuringCatchup = false, SourceFile = file };

                OnLog?.Invoke($"Parsing journal {file}");

                foreach (var line in File.ReadLines(file))
                {
                    var match = Regex.Match(line, "\"event\"\\s*:\\s*\"(?<event>[^\"]+)\"");
                    if (!match.Success)
                        continue;

                    string eventName = match.Groups["event"].Value;

                    if (!EventTypeMap.TryGetValue(eventName, out var eventType))
                        continue;

                    var data = EliteAPI.EventParser.FromJson(eventType, line);
                    if (data != null)
                    {
                        OnLog?.Invoke($"{data.Timestamp} - Full scan : found {eventName}");
                        HandleEliteApiEvent(data, context);
                    }
                }
            }

            ExoData.Cleanup();
        }

        #endregion
    }
}
