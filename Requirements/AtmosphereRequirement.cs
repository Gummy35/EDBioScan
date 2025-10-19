using ExoScan.Enums;
using ExoScan.Helpers;
using ExoScan.StellarStructs;

namespace ExoScan.Requirements
{
    public class AtmosphereRequirement
    {
        public static readonly AtmosphereRequirement Any = new AtmosphereRequirement { IsAny = true };

        public bool IsAny { get; private set; }
        public Atmosphere Types { get; set; }
        public Dictionary<string, double> Components { get; set; }

        private AtmosphereRequirement() { }

        public static AtmosphereRequirement From(params Atmosphere[] types)
        {
            var combined = Atmosphere.None;
            foreach (var type in types)
                combined |= type;
            return new AtmosphereRequirement { Types = combined };
        }

        public static AtmosphereRequirement FromStrings(params string[] atmospheres)
        {
            return new AtmosphereRequirement { Types = AtmosphereHelper.GetCombined(atmospheres) };
        }

        public bool Matches(Atmosphere actualAtmosphere)
        {
            if (IsAny && actualAtmosphere != Atmosphere.None)
                return true;
            return Types.HasFlag(actualAtmosphere);
        }

        public bool Matches(Planet body)
        {
            return Matches(body.Atmosphere);
        }

        public List<string> ToStringList() => AtmosphereHelper.ToList(Types);

        public static bool CheckComponents(Dictionary<string, double> atmosphereComponent, Planet body)
        {
            foreach (var gasEntry in atmosphereComponent)
            {
                if (!body.AtmosphereComposition.ContainsKey(gasEntry.Key)
                    || body.AtmosphereComposition[gasEntry.Key] < gasEntry.Value)
                    return false;
            }
            return true;
        }
    }
}

