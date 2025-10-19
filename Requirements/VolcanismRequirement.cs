using ExoScan.Enums;
using ExoScan.Helpers;
using ExoScan.StellarStructs;

namespace ExoScan.Requirements
{

    public class VolcanismRequirement
    {
        public static readonly VolcanismRequirement Any = new VolcanismRequirement { IsAny = true };
        public static readonly VolcanismRequirement None = new VolcanismRequirement { IsNone = true };

        public bool IsAny { get; private set; }
        public bool IsNone { get; private set; }
        public List<string> Types { get; set; } = new();
        public List<string> ExactMatches { get; set; } = new();
        public List<string> Excluded { get; set; } = new();

        private VolcanismRequirement()
        {
        }

        public static VolcanismRequirement From(params Volcanism[] types)
        {
            var result = new List<string>();
            foreach (var type in types)
                result.Add(VolcanismHelper.Instance.ToString(type));
            return new VolcanismRequirement { Types = result };
        }

        public static VolcanismRequirement FromStrings(params string[] volcanisms)
        {
            List<string> excludes = new();
            List<string> exact = new();
            List<string> types = new();
            foreach (string volcanism in volcanisms)
            {
                if (volcanism.StartsWith("!"))
                {
                    excludes.Add(volcanism.Substring(1));
                }
                else if (volcanism.StartsWith("="))
                {
                    exact.Add(volcanism.Substring(1));
                }
                else
                {
                    types.Add(volcanism);
                }
            }
            return new VolcanismRequirement
            {
                Types = types,
                ExactMatches = exact,
                Excluded = excludes
            };
        }

        public static VolcanismRequirement Exact(params string[] matches)
        {
            return new VolcanismRequirement { ExactMatches = matches.ToList() };
        }

        public bool Matches(string actualVolcanism)
        {
            if (IsAny && !string.IsNullOrEmpty(actualVolcanism))
                return true;

            if (IsNone && string.IsNullOrEmpty(actualVolcanism))
                return true;

            if (ExactMatches.Count > 0)
                if (ExactMatches.Any(match => actualVolcanism == match)) return true;

            if (Excluded.Count > 0)
                if (Excluded.Any(match => actualVolcanism.Contains(match))) return false;


            if (Types.Count > 0)
                if (Types.Any(match => actualVolcanism.Contains(match))) return true;

            return false;
        }

        public bool Matches(Planet body)
        {
            return Matches(body.Volcanism ?? "");
        }

        public List<string> ToStringList()
        {
            if (IsAny) return new List<string> { "Any" };
            if (IsNone) return new List<string> { "None" };
            List<string> result = new List<string>();
            result.AddRange(Types);
            foreach (var match in Excluded)
                result.Add($"!{match}");
            foreach (var match in ExactMatches)
                result.Add($"={match}");
            return result;
        }
    }

}

