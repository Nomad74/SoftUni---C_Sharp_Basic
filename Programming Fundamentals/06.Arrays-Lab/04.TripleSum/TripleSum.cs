using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripleSum
{
    class TripleSum
    {
        static void Main()
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int count = 0;

            for (int a = 0; a < array.Length-1; a++)
            {
                for (int b =a+1; b <array.Length; b++)
                {
                    for (int c = 0; c <array.Length; c++)
                    {
                        if ((c != a || c != b) && (array[a] + array[b] == array[c]))
                        {
                            Console.WriteLine($"{array[a]} + {array[b]} == {array[c]}");
                            count=1;
                        }
                    }
                }
            }
            if (count==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
