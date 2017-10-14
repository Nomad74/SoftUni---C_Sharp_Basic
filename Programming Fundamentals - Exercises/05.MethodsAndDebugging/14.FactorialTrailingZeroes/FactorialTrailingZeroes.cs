using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());
           BigInteger factorial=CalculateFactorial(n);
            int zeroCounter = 0;

            while(factorial%10==0)
            {
                zeroCounter++;
                factorial = factorial / 10;
            }
            Console.WriteLine(zeroCounter);


        }

        private static BigInteger CalculateFactorial(long n)
        {
            BigInteger factorial = 1;

            for (long i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
