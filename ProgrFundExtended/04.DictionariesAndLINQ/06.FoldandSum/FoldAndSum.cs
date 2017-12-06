using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldandSum
{
    class FoldAndSum
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = input.Length / 4;    var sum = new int[input.Length/2];
            
            var firstK = input.Take(k).Reverse();
            var lastK = input.Skip(3 * k).Take(k).Reverse();
            var firstRow = firstK.Concat(lastK).ToArray();
            var secondRow = input.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < firstRow.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
