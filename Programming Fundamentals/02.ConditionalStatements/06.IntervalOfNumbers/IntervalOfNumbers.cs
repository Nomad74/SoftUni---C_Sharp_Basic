using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double minNumber = Math.Min(firstNumber, secondNumber);
            double maxNumber = Math.Max(firstNumber, secondNumber);
            double counter = 0;

            do
            {
                Console.WriteLine(minNumber + counter);
                counter = counter + 1;

            } while ((minNumber + counter) <= maxNumber);
        }
    }
}
