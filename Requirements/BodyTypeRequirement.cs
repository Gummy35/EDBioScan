using ExoScan.Enums;
using ExoScan.Helpers;
using ExoScan.StellarStructs;

namespace ExoScan.Requirements
{
    public class BodyTypeRequirement
    {
        public PlanetType Types { get; set; }

        public static BodyTypeRequirement From(params PlanetType[] types)
        {
            var combined = PlanetType.None;
            foreach (var type in types)
                combined |= type;
            return new BodyTypeRequirement { Types = combined };
        }

        public static BodyTypeRequirement FromStrings(params string[] bodyTypes)
        {
            return new BodyTypeRequirement { Types = BodyTypeHelper.GetCombined(bodyTypes) };
        }

        public bool Matches(string actualBodyType)
        {
            var enumValue = BodyTypeHelper.GetBodyType(actualBodyType);
            return Types.HasFlag(enumValue);
        }

        public bool Matches(Planet body)
        {
            return Types.HasFlag(body.BodyType);
        }

        public List<string> ToStringList() => BodyTypeHelper.ToList(Types);
    }

}

