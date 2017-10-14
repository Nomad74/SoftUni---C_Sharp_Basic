using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Snowflake
{
    class Snowflake
    {
        static void Main()
        {
            var numb = int.Parse(Console.ReadLine());

            for (int i=0; i<numb; i++)
            {
                Console.Write(new string('.',i));
                Console.Write("*");
                if (i+1==numb)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(new string('.', numb - i));
                }
                Console.Write("*");
                if (i + 1 == numb)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(new string('.', numb - i));
                }
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', 2*numb+3));

            for (int i = numb-1; i+1 > 0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write("*");
                if (i + 1 == numb)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(new string('.', numb - i));
                }
                Console.Write("*");
                if (i + 1 == numb)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(new string('.', numb - i));
                }
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.WriteLine();
            }
        }
    }
}
