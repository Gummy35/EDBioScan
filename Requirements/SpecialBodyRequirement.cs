using ExoScan.Enums;
using ExoScan.Helpers;
using ExoScan.StellarStructs;

namespace ExoScan.Requirements
{
    public class SpecialBodyRequirement
    {
        public SpecialBody Bodies { get; set; }

        public static SpecialBodyRequirement From(params SpecialBody[] bodies)
        {
            var combined = SpecialBody.None;
            foreach (var body in bodies)
                combined |= body;
            return new SpecialBodyRequirement { Bodies = combined };
        }

        public static SpecialBodyRequirement FromStrings(params string[] bodies)
        {
            return new SpecialBodyRequirement { Bodies = SpecialBodyHelper.GetCombined(bodies) };
        }

        public bool Matches(string actualBody)
        {
            var enumValue = SpecialBodyHelper.GetSpecialBody(actualBody);
            return Bodies.HasFlag(enumValue);
        }

        public bool Matches(SpecialBody bodyType)
        {
            return Bodies.HasFlag(bodyType);
        }

        public List<string> ToStringList() => SpecialBodyHelper.ToList(Bodies);

        internal bool Matches(Planet body)
        {
            var currentSystem = ExoData.CurrentSystem;
            var result = false;
            foreach (var planet in currentSystem.Planets)
                result |= Matches(planet.SpecialBodyType);
            return result;
        }
    }

}

