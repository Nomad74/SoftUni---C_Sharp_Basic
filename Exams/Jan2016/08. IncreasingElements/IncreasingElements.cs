using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IncreasingElements
{
    class IncreasingElements
    {
        static void Main()
        {
            

            var n = int.Parse(Console.ReadLine());

            double[] array = new double[n];

            for(int i =0; i<array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            var max = array[0];  var sum = 1;  var maxSum = 0;

            for(int i=1; i<array.Length; i++)
            {
                if(array[i]>max)
                {
                    sum = sum + 1;
                }
                else
                {
                    sum = 1;
                }
                if(sum>maxSum)
                {
                    maxSum = sum;
                }
                max = array[i];
            }
            Console.WriteLine(maxSum);
        }
    }
}
