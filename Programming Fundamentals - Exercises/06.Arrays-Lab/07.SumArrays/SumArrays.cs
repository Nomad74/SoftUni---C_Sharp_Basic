using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxArrLenght = Math.Max(arr1.Length, arr2.Length);

            int sum = 0;

            for (int i = 0; i <= maxArrLenght; i++)
            {
                sum = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);

                if (i >= maxArrLenght)
                {
                    break;
                }
                Console.Write($"{sum} ");
            }
            Console.WriteLine();
        }
    }
}
