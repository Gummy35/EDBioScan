using System.Globalization;

namespace ExoScan
{

    // Assuming these exist in your C# project:
    // using ExploData.ExploData.BodyData;
    // using L10n;
    // using BioScan.Globals;

    public static class BodyUtils
    {
        /// <summary>
        /// Return a shorthand for a given body type
        /// </summary>
        /// <param name="bodyType">The ED journal string for a body type</param>
        /// <returns>A shorthand string representing the given body type</returns>
        public static string GetBodyShorthand(string bodyType)
        {
            string shorthand = string.Empty;

            switch (bodyType)
            {
                case "Icy body":
                    shorthand = Translations.Translate("I", BioscanGlobals.TranslationContext);
                    break;
                case "Rocky body":
                    shorthand = Translations.Translate("R", BioscanGlobals.TranslationContext);
                    break;
                case "Rocky ice body":
                    shorthand = Translations.Translate("RI", BioscanGlobals.TranslationContext);
                    break;
                case "Metal rich body":
                    shorthand = Translations.Translate("MR", BioscanGlobals.TranslationContext);
                    break;
                case "High metal content body":
                    shorthand = Translations.Translate("HMC", BioscanGlobals.TranslationContext);
                    break;
            }

            return $" ({shorthand})";
        }

        /// <summary>
        /// Basic search function to check if one of the given body types is present in a dictionary of planet data.
        /// </summary>
        /// <param name="requiredTypes">A list of ED Journal body type strings to search for</param>
        /// <param name="bodies">A dictionary of planet names and ExploData PlanetData objects to search</param>
        /// <returns>Whether or not one of the required body types was found</returns>
        //public static bool BodyCheck(List<string> requiredTypes, Dictionary<string, PlanetData> bodies)
        //{
        //    foreach (var bodyData in bodies.Values)
        //    {
        //        if (requiredTypes.Contains(bodyData.GetBodyType()))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        /// <summary>
        /// Get gravity warning string based on provided gravity value. 2.7G is extreme gravity. 1G is high gravity.
        /// </summary>
        /// <param name="gravity">Surface gravity of a planet (in m/s^2)</param>
        /// <param name="withGravity">Whether or not to include the gravity value (in Gs)</param>
        /// <returns>Gravity warning string. ![#]G! for extreme gravity, ^[#]G^ for high gravity.</returns>
        public static string GetGravityWarning(double? gravity, bool withGravity = false)
        {
            if (gravity.HasValue)
            {
                double gGravity = gravity.Value / 9.80665;
                string gFormatted = gGravity.ToString("F2", CultureInfo.CurrentCulture);

                if (gGravity > 2.69)
                {
                    return withGravity ? $" !{gFormatted}G!" : " !G!";
                }
                if (gGravity >= 1.0)
                {
                    return withGravity ? $" ^{gFormatted}G^" : " ^G^";
                }
                return withGravity ? $" {gFormatted}G" : string.Empty;
            }
            return string.Empty;
        }



        /// <summary>
        /// Get the bearing angle from your current position to the target position using lat/long coordinates.
        /// </summary>
        /// <param name="latLong">The target lat/long coordinates (latitude, longitude)</param>
        /// <returns>The bearing angle (from 0-359)</returns>
        public static double CalcBearing((double latitude, double longitude) latLong)
        {
            var latLong2 = (BioscanGlobals.PlanetLatitude, BioscanGlobals.PlanetLongitude);

            double phi1 = DegreesToRadians(latLong2.Item1);
            double phi2 = DegreesToRadians(latLong.latitude);
            double deltaLambda = DegreesToRadians(latLong.longitude - latLong2.Item2);

            double y = Math.Sin(deltaLambda) * Math.Cos(phi2);
            double x = Math.Cos(phi1) * Math.Sin(phi2)
                       - Math.Sin(phi1) * Math.Cos(phi2) * Math.Cos(deltaLambda);

            double theta = Math.Atan2(y, x);
            return (RadiansToDegrees(theta) + 360) % 360;
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        private static double RadiansToDegrees(double radians)
        {
            return radians * 180.0 / Math.PI;
        }
    }



    public static class Translations
    {
        public static string Translate(string key, string context) { return key; }
    }

    public static class BioscanGlobals
    {
        public static string TranslationContext { get; set; }
        public static double PlanetLatitude { get; set; }
        public static double PlanetLongitude { get; set; }
    }
}
