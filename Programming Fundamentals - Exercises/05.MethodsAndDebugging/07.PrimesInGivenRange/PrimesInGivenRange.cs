using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            var startNumber = long.Parse(Console.ReadLine());
            var endNumber = long.Parse(Console.ReadLine());
            
            Console.Write($"{isPrime}, ");
        }

        private static void IsPrime(long n)
        {
            bool isPrime = false;
            if (n == 0 || n == 1)
            {
                return isPrime;
            }

            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return isPrime;
                }
            }
            return true;
        }
    }
}
