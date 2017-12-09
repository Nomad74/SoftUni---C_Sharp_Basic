using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SplinterTrip
{
    class SplinterTrip
    {
        static void Main(string[] args)
        {
            var distanceInMiles = double.Parse(Console.ReadLine());
            var fuelTankCapacity = double.Parse(Console.ReadLine());
            var milesSpentInHeavyWinds = double.Parse(Console.ReadLine());

            var milesWithoutWinds = distanceInMiles - milesSpentInHeavyWinds;
            var fuelAmountdWithoutWinds = milesWithoutWinds * 25.0;
            var fuelAmountInHeavyWinds = (milesSpentInHeavyWinds * 25.0) * 1.5;

            var FuelAmount = fuelAmountInHeavyWinds+fuelAmountdWithoutWinds ;
            var totalFuelAmount = FuelAmount + FuelAmount * 5.0 / 100.0;

            var fuel = fuelTankCapacity - totalFuelAmount;

            Console.WriteLine($"Fuel needed: {totalFuelAmount:f2}L");
            if (fuel>=0)
            {
                Console.WriteLine($"Enough with {fuel:f2}L to spare!");
            }
            else
            {
                var fuelNeeded = Math.Abs(fuel);
                Console.WriteLine($"We need {fuelNeeded:f2}L more fuel.");
            }
        }
    }
}
