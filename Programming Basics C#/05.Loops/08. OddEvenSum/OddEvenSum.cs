using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            double oddSum = 0; double evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    oddSum = oddSum + num;
                }
                else
                {
                    evenSum = evenSum + num;
                }
            }
            double sum = Math.Abs(oddSum - evenSum);

            if (sum == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+oddSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+sum);
            }
            
        }
    }
}
