using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var sortArray = new string[input.Length];

            for (int i = 1; i <input.Length; i++)
            {
                sortArray[i] = input[i-1];
            }
            sortArray[0] = input[input.Length - 1];

            Console.WriteLine(string.Join(" ", sortArray));
        }
    }
}
