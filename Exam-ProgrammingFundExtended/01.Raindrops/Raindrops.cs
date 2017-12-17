using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Raindrops
{
    class Raindrops
    {
        static void Main()
        {
            double sumAllRegionalCoefficients = 0.0;
            
            var amountOfRegions = int.Parse(Console.ReadLine());
            var density = Double.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfRegions; i++)
            {
                var raindropsCountAndsquareMeters = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                double regionalCoefficient = raindropsCountAndsquareMeters[0] / raindropsCountAndsquareMeters[1];
                sumAllRegionalCoefficients = sumAllRegionalCoefficients + regionalCoefficient;
            }
            var result = sumAllRegionalCoefficients / density;

            Console.WriteLine($"{result:f3}");
        }
    }
}
