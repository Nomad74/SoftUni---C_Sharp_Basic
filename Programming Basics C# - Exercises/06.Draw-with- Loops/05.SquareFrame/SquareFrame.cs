using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+");

            for (int i=1; i<=n-2; i++)
            {
                Console.Write(" ");
                Console.Write("-");
            }
            Console.WriteLine(" +");

            for (int c = 1; c <= n - 2; c++)
            {
                Console.Write("|");

                for (int i = 1; i <= n - 2; i++)
                {
                    Console.Write(" ");
                    Console.Write("-");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+");

            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(" ");
                Console.Write("-");
            }
            Console.WriteLine(" +");
        }
    }
}
