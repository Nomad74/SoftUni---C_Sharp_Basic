using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int sp = 1; sp <= n - i; sp++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star < i; star++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }

            for (int i = 1; i < n; i++)
            {
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star < n-i; star++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
