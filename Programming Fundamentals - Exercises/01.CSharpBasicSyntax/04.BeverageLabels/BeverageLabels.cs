using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main()
        {
            string name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine());
            var sugarContent = double.Parse(Console.ReadLine());

            double kcal = volume * energyContent/100;
            double sugars = volume * sugarContent/100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}
