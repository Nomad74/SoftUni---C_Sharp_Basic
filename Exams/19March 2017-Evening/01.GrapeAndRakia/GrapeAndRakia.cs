using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main()
        {
            var areaGr = double.Parse(Console.ReadLine());
            var kgGrapeM2 = double.Parse(Console.ReadLine());   // kg grape /m2
            var scrapp = double.Parse(Console.ReadLine());

            double rakiaL = 9.80;  double grapeKG = 1.50;

            double sumGrape = (areaGr * kgGrapeM2) - scrapp;
            
            double saleGrape = sumGrape-( sumGrape * 0.45);
            double grapeRakia= sumGrape- (sumGrape * 0.55);

            double sumRakia = grapeRakia / 7.5;

            double inkomRakia = sumRakia * rakiaL;
            double inkomGrape = saleGrape * grapeKG;

            Console.WriteLine($"{inkomRakia:f2}");
            Console.WriteLine($"{inkomGrape:f2}");

        }
    }
}
