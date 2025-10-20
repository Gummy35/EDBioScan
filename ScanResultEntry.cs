using ExoScan.Enums;
using ExoScan.Helpers;
using ExoScan.RuleSets;
using ExoScan.StellarStructs;
using static ExoScan.CodexData.CodexIds;

namespace ExoScan
{
    public class ScanResultEntry
    {
        public static List<ScanResultEntry> GetEntries(Planet body, ScanCacheEntry r)
        {
            var res = new List<ScanResultEntry>();
            if (r != null)
            {
                var baseEntry = new ScanResultEntry
                {
                    Name = r.Display,
                    AtmosphereType = AtmosphereHelper.GetAtmosphereTypeName(body.Atmosphere),
                    BodyName = body.Name,
                    Genus = r.Genus,
                    Distance = GenusData.Data[r.Genus].Distance,
                    PlanetClass = BodyTypeHelper.GetBodyTypeName(body.BodyType),
                    Seen = (body.Floras.Count > 0 && body.Floras.ContainsKey(r.Genus) && body.Floras[r.Genus].Scans.Count > 0) ? BioSeen.Seen : BioSeen.NotSeen
                };

                var count = body.BioSignals == null ? body.Floras.Count() : body.BioSignals.Value;
                if (count == 0 && !body.Statuses.Any(s => s.Mapped))
                    count = -1;
                baseEntry.BioSignalCount = count;

                if (r.Species.Count == 1)
                {
                    var display = GenusData.GetSpeciesName((ushort)r.Species.Keys.First());
                    baseEntry.Value = r.MinValue;
                    baseEntry.Name = display;
                    res.Add(baseEntry);
                }
                else if (r.Species.Count > 1)
                {
                    baseEntry.Value = r.MinValue;
                    baseEntry.MaxValue = r.MaxValue;
                    baseEntry.Name = $"{r.Display} (x{r.Species.Count})";
                    res.Add(baseEntry);
                }
                else
                {
                    baseEntry.Value = r.MaxValue;
                    res.Add(baseEntry);
                }
            }
            return res;
        }

        public string GetHash()
        {
            return $"{Value}|{MaxValue}|{Name}|{Distance}|{BodyName}|{PlanetClass}|{AtmosphereType}|{Seen}|{Genus}|{Species}|{string.Join(',', Variants)}";
        }

        public long Value { get; set; }
        public long? MaxValue { get; set; } = null;
        public string Name { get; set; }
        public int Distance { get; set; }
        public string BodyName { get; set; }
        public string PlanetClass { get; set; }
        public int BioSignalCount { get; set; }
        public string AtmosphereType { get; set; }
        public BioSeen Seen { get; set; }
        public GenusEnum Genus { get; set; }
        public int Species { get; set; }
        public List<string> Variants { get; set; } = new();
    }
}

public class ScanCacheEntry
{
    public class SpeciesDataEntry
    {
        public List<string> Variants { get; set; } = new();
        public int Value { get; set; }
    }
    public GenusEnum Genus { get; set; }
    public string Display { get; set; }
    public int MinValue { get; set; }
    public int MaxValue { get; set; }
    public Dictionary<int, SpeciesDataEntry> Species { get; set; } = new();
}
