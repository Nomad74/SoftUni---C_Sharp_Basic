using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var firstNumber = double.Parse(Console.ReadLine());

            double min = firstNumber;

            for (int i = 1; i <= n - 1; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);

        }
    }
}

