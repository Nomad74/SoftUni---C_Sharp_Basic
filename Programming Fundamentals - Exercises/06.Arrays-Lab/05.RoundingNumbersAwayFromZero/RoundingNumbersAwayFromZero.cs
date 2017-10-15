using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i <array.Length; i++)
            {
                double rounded = Math.Round(array[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {rounded}");
            }
        }   
    }
}
