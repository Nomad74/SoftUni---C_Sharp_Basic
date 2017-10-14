using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle
{
    class Triangle
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());  var c = 0;  var a = 0;

            Console.WriteLine(new string('#',(4*n)+1));

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('#', (n * 2) - 1 - c));
                if (i == (n / 2 + 1))
                {
                    a = ((c + 1) / 2) - 1;
                    Console.Write(new string(' ', a));
                    Console.Write("(@)");
                    Console.Write(new string(' ', a));
                }
                else
                {
                    Console.Write(new string(' ', 1 + c));
                }
                Console.Write(new string('#', (n * 2) - 1 - c));
                Console.WriteLine(new string('.', i));
                c = c + 2;
            }
            c = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.',n+i));
                Console.Write(new string('#', (n * 2) - 1 - c));
                Console.WriteLine(new string('.', n + i));
                c = c + 2;
            }




        }
    }
}
