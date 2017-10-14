using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Profit
{
    class Profit
    {
        static void Main()
        {
            var one = int.Parse(Console.ReadLine());
            var two = int.Parse(Console.ReadLine());
            var five = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());
    
            int midSum = 0;

            for (int a= 0; a <=one; a++)
            {
                for (int b = 0; b <= two; b++)
                {
                    for (int c = 0; c <= five; c++)
                    {
                        midSum = (a * 1) + (b * 2) + (c * 5);

                        if (midSum == sum)
                        {
                            Console.WriteLine($"{a} * 1 lv. + {b} * 2 lv. + {c} * 5 lv. = {sum} lv.");
                        }
                    }
                }
                    
            }
        }
    }
}
