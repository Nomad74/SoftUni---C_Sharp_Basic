using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = input.Length / 4;

            var firstLeft = input.Take(k).Reverse().ToArray();
            var lastRight = input.Reverse().Take(k).ToArray();
            int[] firstRow = firstLeft.Concat(lastRight).ToArray();

            var secondRow = input.Skip(k).Take(2 * k).ToArray();

            var sum = firstRow.Select((x, index) => x + secondRow[index]);
            Console.WriteLine(string.Join(" " ,sum));
        }
    }
}
