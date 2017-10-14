using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int count = 0;  int c = 0;

            for (int a = n; a <= m; a++)
            {
                for (int b = n; b <= m; b++)
                {
                    count++;
                    if((a+b)==magicNumber)
                    {
                        Console.WriteLine($"Number found! {b} + {a} = {magicNumber}");
                        a = m; b = m; c = 1;
                    }
                }
            }
            if (c==0)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
