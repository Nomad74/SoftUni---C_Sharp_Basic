using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Company
{
    class Company
    {
        static void Main()
        {
            var days = double.Parse(Console.ReadLine());
            var numbBekary = double.Parse(Console.ReadLine());
            var numbCakes = double.Parse(Console.ReadLine());
            var numbGofr = double.Parse(Console.ReadLine());
            var numbPanC = double.Parse(Console.ReadLine());

            

            var cakes = numbCakes * 45.0;
            var gofr = numbGofr * 5.8;
            var panc = numbPanC * 3.2;

            var oneBekary = cakes + gofr + panc;

            var s = oneBekary * numbBekary;
            var sum = s * days;

            sum = sum - (sum  / 8);

            Console.WriteLine($"{sum:f2}");


        }
    }
}
