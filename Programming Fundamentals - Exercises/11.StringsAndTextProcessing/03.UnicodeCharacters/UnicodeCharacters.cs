using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(char.Parse).ToList();

            foreach (var item in input)
            {
                Console.WriteLine(String.Join(" ", input));
            }
        }
    }
}
