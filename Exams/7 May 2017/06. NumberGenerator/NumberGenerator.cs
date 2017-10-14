using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberGenerator
{
    class NumberGenerator
    {
        static void Main()
        {
            var m = Console.ReadLine();
            var n = Console.ReadLine();
            var l = Console.ReadLine();
            var spec = double.Parse(Console.ReadLine());
            var contr = double.Parse(Console.ReadLine());
            int mnl = int.Parse( m + n + l);
            int counter = 10;
                                              
            for (int i = mnl; i >= 111; i--)
            {
                if (i % 3 == 0)
                {
                    spec = spec + 5;
                }
                else if (i % 5 == 0)
                {
                    spec = spec - 2;
                }
                else if (i % 2 == 0)
                {
                    spec = spec * 2;
                }
                if (spec >= contr)
                {
                    Console.WriteLine($"Yes! Control number was reached! Current special number is {spec}.");
                    break;
                }
                
                if((i-111)%10==0)
                {
                    i = 1+mnl - counter;
                    counter += 10;
                }
            }
            if (spec < contr)
            {
                Console.WriteLine($"No! {spec} is the last reached special number.");
            }
        }
    }
}
