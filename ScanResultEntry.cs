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
                if (r.Species.Count == 1)
                {
                    //foreach (var species in r.Species)
                    //{

                    var display = GenusData.GetSpeciesName((ushort)r.Species.Keys.First());
                    var baseEntry = new ScanResultEntry
                    {
                        //Value = species.Value.Value,
                        Value = r.MinValue,
                        Name = display,
                        AtmosphereType = AtmosphereHelper.GetAtmosphereTypeName(body.Atmosphere),
                        BodyName = body.Name,
                        Genus = r.Genus,
                        Distance = GenusData.Data[r.Genus].Distance,
                        PlanetClass = BodyTypeHelper.GetBodyTypeName(body.BodyType),
                        Seen = (body.Floras.Count > 0 && body.Floras.ContainsKey(r.Genus) && body.Floras[r.Genus].Scans.Count > 0) ? BioSeen.Seen : BioSeen.NotSeen,
                        //                            Species = species.Key,
                        //                            Variants = species.Value.Variants.ToList()
                    };
                    res.Add(baseEntry);
                    //                    }
                }
                else
                if (r.Species.Count > 1)
                {
                    //foreach (var species in r.Species)
                    //{
                    var baseEntry = new ScanResultEntry
                    {
                        //Value = species.Value.Value,
                        Value = r.MinValue,
                        MaxValue = r.MaxValue,
                        Name = $"{r.Display} (x{r.Species.Count})",
                        AtmosphereType = AtmosphereHelper.GetAtmosphereTypeName(body.Atmosphere),
                        BodyName = body.Name,
                        Genus = r.Genus,
                        Distance = GenusData.Data[r.Genus].Distance,
                        PlanetClass = BodyTypeHelper.GetBodyTypeName(body.BodyType),
                        Seen = (body.Floras.Count > 0 && body.Floras.ContainsKey(r.Genus) && body.Floras[r.Genus].Scans.Count > 0) ? BioSeen.Seen : BioSeen.NotSeen,
                        //                            Species = species.Key,
                        //                            Variants = species.Value.Variants.ToList()
                    };
                    res.Add(baseEntry);
                    //                    }
                }
                else
                {
                    var baseEntry = new ScanResultEntry
                    {
                        Value = r.MaxValue,
                        Name = r.Display,
                        AtmosphereType = AtmosphereHelper.GetAtmosphereTypeName(body.Atmosphere),
                        BodyName = body.Name,
                        Genus = r.Genus,
                        Distance = GenusData.Data[r.Genus].Distance,
                        PlanetClass = BodyTypeHelper.GetBodyTypeName(body.BodyType),
                        Seen = (body.Floras.Count > 0 && body.Floras.ContainsKey(r.Genus) && body.Floras[r.Genus].Scans.Count > 0) ? BioSeen.Seen : BioSeen.NotSeen
                    };
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
