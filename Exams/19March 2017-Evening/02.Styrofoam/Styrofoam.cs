using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Styrofoam
{
    class Styrofoam
    {
        static void Main()
        {
            var biudjet = double.Parse(Console.ReadLine());
            var areaHouse = double.Parse(Console.ReadLine());
            var numbWindows = double.Parse(Console.ReadLine());
            var m2StyrofoamInBox = double.Parse(Console.ReadLine());
            var piceBoxStyrofoam = double.Parse(Console.ReadLine());

            double clearAreaHouse = areaHouse - (numbWindows * 2.4);
            double firaStyrofoam = clearAreaHouse * 0.1;

            double boxesStyrofoam = Math.Ceiling( (clearAreaHouse + firaStyrofoam) / m2StyrofoamInBox);
            
            double sumStyrofoam = boxesStyrofoam * piceBoxStyrofoam;

            if(biudjet>=sumStyrofoam)
            {
                Console.WriteLine($"Spent: {sumStyrofoam:f2}");
                Console.WriteLine($"Left: {(biudjet-sumStyrofoam):f2}");
            }
            else
            {
                double need = Math.Abs(biudjet - sumStyrofoam);
                Console.WriteLine($"Need more: {need:f2}");
            }
        }
    }
}
