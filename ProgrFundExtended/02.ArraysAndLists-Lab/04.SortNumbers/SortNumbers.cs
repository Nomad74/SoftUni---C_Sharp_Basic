using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            input.Sort();

            for (int  i=0; i < input.Count; i++)
            {
                Console.Write($"{input[i]}");
                if (i<input.Count-1)
                {
                    Console.Write(" <= ");
                }
            }
            Console.WriteLine();
        }
    }
}