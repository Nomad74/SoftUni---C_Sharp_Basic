using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Factorial
    {
        static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (long i=1; i<=number; i++)
            {
                factorial=factorial*i;
            }
            Console.WriteLine(factorial);
        }
    }
}
