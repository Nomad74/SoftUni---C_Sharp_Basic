using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NameOfTheLastDigit
{
    class NameOfTheLastDigit
    {
        static void Main()
        {
            PrintLastDigitInEnglish();
        }

        private static void PrintLastDigitInEnglish()
        {
            long number = long.Parse(Console.ReadLine());
            long lastDigit = number % 10;
            string[] array = { "zero", "one", "two", "tree", "four", "five", "six", "seven", "eight", "nine" };
            for (int i = 0; i <= 9; i++)
            {
                if (lastDigit == i)
                {
                    string lastDigitInEnglish = array[i];
                    Console.WriteLine(lastDigitInEnglish);
                }
            }
        }
    }
}
