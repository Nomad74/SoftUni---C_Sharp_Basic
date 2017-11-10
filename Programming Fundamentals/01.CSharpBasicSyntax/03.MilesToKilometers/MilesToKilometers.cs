using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main()
        {
            var miles = double.Parse(Console.ReadLine());

            double result = miles * 1.60934;

            Console.WriteLine($"{result:f2}");
        }
    }
}
