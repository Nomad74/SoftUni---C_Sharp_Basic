using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonachi
{
    class Fibonachi
    {
        static void Main()
        {
            var f0 = 1; var f1 = 1; var sum = 0;

            var n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    sum = f0 + f1;
                    f0 = f1;
                    f1 = sum;

                }
                Console.WriteLine(sum);
            }
        } 
    }
}
