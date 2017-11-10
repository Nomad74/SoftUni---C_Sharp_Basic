using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] firstLast =new int [k * 2];
            int[] middle = new int[k * 2];
            int[] sum = new int[k * 2];

            for (int i = 0; i < array.Length; i++)
            {
                if (i < k)
                {
                    firstLast[firstLast.Length - 1 - k - i] = array[i];
                }
                else if(i>=k && i<k*3)
                {
                    middle[i - k] = array[i];
                }
                else if(i>=k*3)
                {
                    firstLast[()] = array[i];
                }
            }
            for (int i = 0; i <k*2; i++)
            {
                Console.Write($"{sum[i]=firstLast[i]+middle[i]} ");
            }
            Console.WriteLine();
        }
    }
}
