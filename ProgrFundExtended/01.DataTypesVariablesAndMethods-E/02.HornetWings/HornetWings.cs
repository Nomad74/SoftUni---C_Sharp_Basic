using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distFor1000WF = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            int numbRest = wingFlaps / endurance;
            int timeLost = numbRest * 5;
            int time = wingFlaps / 100;
            int sumTime = time + timeLost;
            double distance = distFor1000WF * wingFlaps / 1000;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{sumTime} s.");
        }
    }
}
