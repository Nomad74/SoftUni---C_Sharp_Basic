using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSumSequence
{
    class LastKNumbersSumSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            array[0] = 1; int sum = 0;

            for (int i = 1; i < n; i++)
            {
                sum = 0;
                for (int j = i-k; j <= i-1; j++)
                {
                    if(j>=0)
                    {
                        sum += array[j];
                        array[i] = sum;
                    }
                }
            }
               Console.WriteLine(string.Join(" ",array));
        }
    }
}
