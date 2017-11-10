using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            for (int i = array.Length-1; i >=0; i--)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
