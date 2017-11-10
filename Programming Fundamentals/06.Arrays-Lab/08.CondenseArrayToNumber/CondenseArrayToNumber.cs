using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condArray = new int[array.Length];

            int sum = 0;

            for (int i = 0; i <array.Length-1; i++)
            {
                for (int j=0; j<array.Length-i-1; j++)
                {
                    condArray[j] = array[j] + array[j+1];
                    array[j] = condArray[j];
                    sum = array[j];
                }
            }
            if(array.Length==1)
            {
                Console.WriteLine(array[0]);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
