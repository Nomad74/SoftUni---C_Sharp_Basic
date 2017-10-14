using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumsStep
{
    class SumsStep
    {
        static void Main()
        {
            var sum1 = 0; var sum2 = 0; var sum3 = 0;

            var n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for(int i=0; i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i+=3)
            {
                sum1 = sum1 + array[i];
            }
            for (int i = 1; i < array.Length; i += 3)
            {
                sum2 = sum2 + array[i];
            }
            for (int i = 2; i < array.Length; i += 3)
            {
                sum3 = sum3 + array[i];
            }
            Console.WriteLine($"sum1 = {sum1}");
            Console.WriteLine($"sum2 = {sum2}");
            Console.WriteLine($"sum3 = {sum3}");
        }
    }
}
