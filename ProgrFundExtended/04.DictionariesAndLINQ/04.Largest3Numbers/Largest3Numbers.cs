using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = 3;

            if (input.Length<3)
            {
                n = input.Length;
            }
            var result = input.OrderByDescending(x => x).Take(n);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
