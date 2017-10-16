using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SearchNumber
{
    class SearchNumber
    {
        static void Main(string[] args)
        {
            List<int> numbers;
            int[] arrayOfThreeNumbers;
            ReadingInputOfNumbers(out numbers, out arrayOfThreeNumbers);

            int firstNumber = arrayOfThreeNumbers[0];
            int secondNumber = arrayOfThreeNumbers[1];
            int thirdNumber = arrayOfThreeNumbers[2];

            var saveNewNumbers = numbers.Take(firstNumber).ToList();
            saveNewNumbers.RemoveRange(0, secondNumber);

            if (saveNewNumbers.Contains(thirdNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }

        private static void ReadingInputOfNumbers(out List<int> numbers, out int[] arrayOfThreeNumbers)
        {
            numbers = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            arrayOfThreeNumbers = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();
        }
    }
}
