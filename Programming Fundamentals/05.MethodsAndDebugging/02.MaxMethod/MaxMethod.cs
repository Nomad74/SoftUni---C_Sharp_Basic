using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class MaxMethod
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            GetMax(a, b, c);
        }

        private static void GetMax(int a, int b, int c)
        {
            int maxNumber = Math.Max(Math.Max(a, b), c);
            Console.WriteLine(maxNumber);
        }
    }
}
