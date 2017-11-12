using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.BigPower
{
    class BigPower
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger numb = 1;

            for (int i = 0; i < n; i++)
            {
                numb*= n;
            }
            Console.WriteLine(numb);
        }
    }
}
