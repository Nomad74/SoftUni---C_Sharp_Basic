using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConvertFromBaseN
{
    class ConvertFromBase10
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = input [0];
            ulong number = (ulong) input [1];
            ulong remainder;
            string result = "";

            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    remainder = number % (ulong)n;
                    number /= (ulong)n;

                    result = remainder.ToString() + result;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
