using ExoScan.Enums;
using ExoScan.Helpers;
using ExoScan.StellarStructs;

namespace ExoScan.Requirements
{
    public class RegionRequirement
    {
        public List<GalacticRegion> IncludedRegions { get; set; }
        public List<GalacticRegion> ExcludedRegions { get; set; }

        public RegionRequirement()
        {
            IncludedRegions = new List<GalacticRegion>();
            ExcludedRegions = new List<GalacticRegion>();
        }

        public static RegionRequirement FromStrings(params string[] regions)
        {
            var req = new RegionRequirement();
            foreach (var region in regions)
            {
                if (region.StartsWith("!"))
                    req.ExcludedRegions.Add(RegionHelper.GetRegion(region.Substring(1)));
                else
                    req.IncludedRegions.Add(RegionHelper.GetRegion(region));
            }
            return req;
        }

        public bool Matches(int sector)
        {
            foreach (var region in ExcludedRegions)
                if (Zones.RegionMap[region].Contains(sector))
                    return false;

            foreach (var region in IncludedRegions)
                if (Zones.RegionMap[region].Contains(sector))
                    return true;

            return false;
        }

        public bool Matches(Planet body)
        {
            var currentSystem = ExoData.CurrentSystem;
            if (currentSystem.Region != null)
            {
                return Matches(currentSystem.Region.Value);
            }
            return true;
        }

        public List<string> ToStringList()
        {
            var result = new List<string>();
            result.AddRange(ExcludedRegions.Select(r => "!" + RegionHelper.GetRegionName(r)));
            result.AddRange(IncludedRegions.Select(RegionHelper.GetRegionName));
            return result;
        }

        internal static bool InGuardianNebulae(Planet body)
        {
            var currentSystem = ExoData.CurrentSystem;
            foreach (var guardianEntry in Zones.GuardianNebulae)
            {
                string zone = guardianEntry.Key;
                var info = guardianEntry.Value;
                var coordinates = info.coordinates;
                double distance = coordinates.GetDistance(currentSystem.Position);
                if (distance < info.maxDistance) return true;
            }
            return false;
        }

        internal static bool InTuberSector(object tuber, Planet body)
        {
            var currentSystem = ExoData.CurrentSystem;
            foreach (var tuberEntry in Zones.TuberZones)
            {
                string zone = tuberEntry.Key;
                var info = tuberEntry.Value;
                var coordinates = info.coordinates;
                double distance = coordinates.GetDistance(currentSystem.Position);
                if (distance > info.minDistance && distance < info.maxDistance) return true;
            }
            return false;
        }


    }

}

