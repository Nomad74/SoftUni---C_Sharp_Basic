using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        public static ulong Fib(ulong n)
        {
            ulong fibNumb = 0ul;
            if (n==0)
            {
                fibNumb = 1ul;
                return fibNumb;
            }

             ulong a = 1ul; ulong b = 0ul;

            for(ulong i=1; i<=n; i++)
            {
                fibNumb = a + b;
                b = a;
                a = fibNumb;
            }
            return fibNumb;
        }
        
    }
}
