using ExoScan.Enums;
using ExoScan.Requirements;

namespace ExoScan
{
    public class Ruleset
    {
        public AtmosphereRequirement? Atmosphere { get; set; }
        public Dictionary<string, double>? AtmosphereComponent { get; set; }
        public BodyTypeRequirement? BodyType { get; set; }
        public VolcanismRequirement? Volcanism { get; set; }
        public RegionRequirement? Region { get; set; }
        public StarRequirement? ParentStar { get; set; }
        public StarRequirement? Star { get; set; }
        public SpecialBodyRequirement? Bodies { get; set; }

        public double? MinGravity { get; set; }
        public double? MaxGravity { get; set; }
        public double? MinTemperature { get; set; }
        public double? MaxTemperature { get; set; }
        public double? MinPressure { get; set; }
        public double? MaxPressure { get; set; }
        public double? MaxOrbitalPeriod { get; set; }
        public bool Guardian { get; set; } = false;
        public object? Tuber { get; set; }
        public NebulaType? Nebula { get; set; }
        public double? Distance { get; set; }
    }

}

