using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bills
{
    class Bills
    {
        static void Main()
        {
            var numMonths = int.Parse(Console.ReadLine());

            double [] months = new  double [numMonths];
            double sumEl = 0;  double water = 0;  double net = 0;  double other = 0; double average = 0;

            for (int i=0; i<months.Length; i++)
            {
               months [i] = double.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < months.Length; i++)
            {
               sumEl=sumEl+ months[i] ;
            }

            water = numMonths * 20.0;
            net = numMonths * 15.0;

            other = sumEl + water + net;
            other = other + (other * 0.2);

            average = (sumEl + water + net + other) / numMonths;

            Console.WriteLine($"Electricity: {sumEl:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {net:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
