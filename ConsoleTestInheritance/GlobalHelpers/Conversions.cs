using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTestInheritance.GlobalHelpers
{
    internal static class Conversions
    {
        const double earthRadius = 6371; //earth’s radius (mean radius = 6,371km)

        internal static float MetersToMiles(float meters)
        {
            return (meters / 1609.34F);
        }

        internal static float SecondsToHours(float seconds)
        {
            return (seconds / (3600F));
        }

        internal static double LongLatToDegreeBearing(double lat1, double lon1, double lat2, double lon2)
        {
            var dLon = DegreesToRad(lon2 - lon1);
            var dPhi = Math.Log(
                Math.Tan(DegreesToRad(lat2) / 2 + Math.PI / 4) / Math.Tan(DegreesToRad(lat1) / 2 + Math.PI / 4));
            if (Math.Abs(dLon) > Math.PI)
                dLon = dLon > 0 ? -(2 * Math.PI - dLon) : (2 * Math.PI + dLon);

            return RadToBearing(Math.Atan2(dLon, dPhi));
        }

        private static double DegreesToRad(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        private static double RadToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }

        private static double RadToBearing(double radians)
        {
            // convert radians to degrees (as bearing: 0...360)
            return (RadToDegrees(radians) + 360) % 360;
        }
    }
}
