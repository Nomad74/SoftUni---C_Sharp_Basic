using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Crown
{
    class Crown
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int dot = 1;  int space = 1;

            Console.WriteLine("@{0}@{1}@", new string(' ', n - 2), new string(' ', n - 2));
            Console.WriteLine("**{0}*{1}**", new string(' ', n - 3), new string(' ', n - 3));

            for (int col = 1; col <= (n / 2)-2; col++)
            {
               
                Console.Write("*{0}*{1}*{2}*{1}*{0}*",
                              new string('.', space),
                              new string(' ', (n / 2) - dot),
                              new string('.', dot)
                                                          );
                space++;
                dot += 2;
                Console.WriteLine();

            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', space), new string('.', dot));

                space++;
                dot += 2;

            Console.WriteLine("*{0}*{1}*{0}*", new string('.', space), new string('.', dot));

            Console.WriteLine(new string ('*',((n*2)-1)));
            Console.WriteLine(new string('*', ((n * 2) - 1)));
        }
    }
}
