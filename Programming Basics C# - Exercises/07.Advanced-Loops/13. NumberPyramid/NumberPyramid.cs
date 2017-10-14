using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    class NumberPyramid
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;

            for(int row=1; row<=n; row++)
            {
                for(int col=0; col<row; col++)
                {
                    Console.Write($"{num} ");
                    num++;
                    if (num > n)
                        break;
                }
                    if (num > n)
                        break;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
