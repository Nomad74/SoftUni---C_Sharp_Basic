using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LargestNElements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());
            input.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{input[input.Count - 1 - i]} ");
            }
            Console.WriteLine();
        }
    }
}
