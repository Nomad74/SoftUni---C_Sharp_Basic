using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumTreeNumbers
{
    class SumTreeNumbers
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var min2 = c;
            var min1 = Math.Min(a, b);
            var max = Math.Max(a, b);

            if(c<=min1)
            {
                min2 = min1;  min1 = c;
            }
            else if (c>=max)
            {
                min2 = max;  max = c; 
            }
            if(min1+min2==max)
            {
                Console.WriteLine($"{min1} + {min2} = {max}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
 