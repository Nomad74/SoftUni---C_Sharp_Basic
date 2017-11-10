using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double maxSum = double.Parse(Console.ReadLine());

            double sum = 0;  int count = 0; double num = 0; int c = 0;
            for (double a = n; a >= 1; a--)
            {
                for (double b = 1; b <= m; b++)
                {
                    num = 3 * (a * b);
                    sum = sum + num;
                    count++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        a = 0; b = m + 1; c = 1;
                    }
                  
                }
            }
            if (c == 0)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
