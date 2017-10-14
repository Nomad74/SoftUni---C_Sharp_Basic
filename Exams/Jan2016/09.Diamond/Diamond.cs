using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Diamond
{
    class Diamond
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n - 1));
            Console.WriteLine("*");

            for (int col = 1; col <= n - 1; col++)
            {
                Console.Write(new string(' ', n - col-1));

                for (int row = 0; row < col; row++)
                {
                    Console.Write("*-");
                }
                Console.WriteLine("*");
            }
            for (int col = 1; col<=n-1; col++)
            {
                Console.Write(new string(' ',col));

                for (int row = 0; row < (n-col-1); row++)
                {
                    Console.Write("*-");
                }
                Console.WriteLine("*");
            }
        }
    }
}
