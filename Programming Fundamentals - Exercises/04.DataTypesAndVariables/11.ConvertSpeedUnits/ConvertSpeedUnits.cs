using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            float hours = byte.Parse(Console.ReadLine());
            float minutes = byte.Parse(Console.ReadLine());
            float seconds = byte.Parse(Console.ReadLine());

            float sumSeconds = seconds + minutes * 60.0f + hours * 3600.0f;
            float sumHoures = sumSeconds / 3600.0f;
            float distanceKM = distanceMeters / 1000.0f;
            float distanceMiles = distanceMeters / 1609.0f;

            float metersPerSeconds =distanceMeters / sumSeconds;
            float kilometersPerHour =distanceKM/sumHoures;
            float milesPerHour = distanceMiles/sumHoures;

            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
