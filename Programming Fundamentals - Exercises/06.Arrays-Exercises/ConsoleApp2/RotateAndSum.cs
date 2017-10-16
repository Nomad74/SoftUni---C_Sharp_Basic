using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] rotArray = new int[array.Length];
            int[] sumArray = new int[array.Length];

            for (int i = 0; i <n; i++)
            {
                rotArray[0] = array[array.Length - 1-i];

                for (int j = 0; j < array.Length-1; j++)
                {
                    rotArray[j] = array[j-1-i];
                    sumArray[j] += rotArray[j];
                }
            }
            Console.WriteLine(String.Join(" ", sumArray));
        }
    }
}
