using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string [] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2= Console.ReadLine().Split(' ').ToArray();

            int countLeft = 0; int countRight = 0; int count = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i])
                {
                    countLeft++;
                }
            }
            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[arr1.Length-1-i] == arr2[arr2.Length - 1 - i])
                {
                   countRight++ ;
                }
            }
            count = Math.Max(countLeft, countRight);

            Console.WriteLine(count);
        }
    }
}
