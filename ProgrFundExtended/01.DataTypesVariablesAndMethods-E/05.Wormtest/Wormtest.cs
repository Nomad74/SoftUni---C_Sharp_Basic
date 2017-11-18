using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wormtest
{
    class Wormtest
    {
        static void Main(string[] args)
        {
            double lenghtM = double.Parse(Console.ReadLine());
            double widthCM = double.Parse(Console.ReadLine());

            double lenghtCM = lenghtM * 100.00;

            var reminder = lenghtCM % widthCM;
            if (reminder == 0)
            {
                Console.WriteLine($"{(lenghtCM*widthCM):f2}");
            }
            else
            {
                Console.WriteLine($"{((lenghtCM/widthCM)*100):f2}%");
            }
        }
    }
}
