using ExoScan.Enums;
using ExoScan.Helpers;
using ExoScan.StellarStructs;

namespace ExoScan.Requirements
{
    public class StarRequirement
    {
        public List<(StarType type, StarLuminosity? luminosity)> Requirements { get; set; }

        public StarRequirement()
        {
            Requirements = new List<(StarType, StarLuminosity?)>();
        }

        public static StarRequirement From(params StarType[] types)
        {
            var req = new StarRequirement();
            foreach (var type in types)
                req.Requirements.Add((type, null));
            return req;
        }

        public static StarRequirement From(params (StarType type, StarLuminosity luminosity)[] requirements)
        {
            return new StarRequirement
            {
                Requirements = requirements.Select(r => ((StarType, StarLuminosity?))r).ToList()
            };
        }

        public static StarRequirement FromStrings(params string[] stars)
        {
            var req = new StarRequirement();
            foreach (var star in stars)
            {
                req.Requirements.Add((StarTypeHelper.GetStarType(star), null));
            }
            return req;
        }

        public static StarRequirement FromTuples(params (string type, string luminosity)[] stars)
        {
            var req = new StarRequirement();
            foreach (var (type, luminosity) in stars)
            {
                req.Requirements.Add((
                    StarTypeHelper.GetStarType(type),
                    luminosity == null ? null : StarLuminosityHelper.GetLuminosity(luminosity)
                ));
            }
            return req;
        }

        /// <summary>
        /// Check if the given star type string (by ED journal value) matches a base type identifier.
        /// This is necessary because super giants have different type IDs from standard stars and certain star types have
        /// variations with qualifiers where a basic equality comparison is insufficient.
        /// </summary>
        /// <param name="starQuery">Simple star type string (A, F, K, O, D, H, etc.)</param>
        /// <param name="starType">ED journal type string for comparison star</param>
        /// <returns>Whether the basic query type matches the ED journal type string</returns>
        public static bool StarCheck(StarType starQuery, string starType)
        {
            return starQuery switch
            {
                StarType.A => starType == "A" || starType == "A_BlueWhiteSuperGiant",
                StarType.B => starType == "B" || starType == "B_BlueWhiteSuperGiant",
                StarType.F => starType == "F" || starType == "F_WhiteSuperGiant",
                StarType.G => starType == "G" || starType == "G_WhiteSuperGiant",
                StarType.K => starType == "K" || starType == "K_OrangeGiant",
                StarType.M => starType == "M" || starType == "M_RedGiant" || starType == "M_RedSuperGiant",
                StarType.D or StarType.W => starType.StartsWith(StarTypeHelper.GetStarTypeName(starQuery)),
                _ => starType == StarTypeHelper.GetStarTypeName(starQuery)
            };
        }

        //public bool Matches(StarTypeEnum actualType, StarLuminosityEnum? actualLuminosity = null)
        //    {
        //        foreach (var req in Requirements)
        //        {
        //            if (req.type == actualType)
        //            {
        //                if (req.luminosity == null || req.luminosity == actualLuminosity)
        //                    return true;
        //            }
        //        }
        //        return false;
        //    }

        public List<object> ToObjectList()
        {
            var result = new List<object>();
            foreach (var req in Requirements)
            {
                if (req.luminosity.HasValue)
                    result.Add((StarTypeHelper.GetStarTypeName(req.type), StarLuminosityHelper.GetStarLuminosityName(req.luminosity.Value)));
                else
                    result.Add(StarTypeHelper.GetStarTypeName(req.type));
            }
            return result;
        }



        internal bool MatchesParent(Planet body)
        {
            var currentSystem = ExoData.CurrentSystem;

            foreach (var star in body.GetParentStars())
            {
                foreach (var req in Requirements)
                {
                    if (StarCheck(req.type, star.StarType)) return true;
                }
            }
            return false;
        }

        internal bool MatchesSystemStars(Planet body)
        {
            var currentSystem = ExoData.CurrentSystem;

            foreach (var star in currentSystem.Stars)
            {
                foreach (var req in Requirements)
                {
                    if (req.luminosity == null)
                    {
                        if (StarCheck(req.type, star.StarType)) return true;
                    }
                    else
                    {
                        if (StarCheck(req.type, star.StarType))
                        {
                            foreach (string flag in new[] { "", "a", "b", "ab", "z" })
                            {
                                if (StarLuminosityHelper.GetStarLuminosityName(req.luminosity.Value) + flag == star.Luminosity.ToString())
                                    return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }

}

