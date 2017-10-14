using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            var firstValue = double.Parse(Console.ReadLine());
            var secondValue = double.Parse(Console.ReadLine());

            double sum = firstValue + secondValue;

            double oldSum = sum;

            double currentSum = sum;
            double difference = 0;
            double maxDifference = 0;
           

            for (int i=1; i<=n-1; i++)
            {
                var fValue = double.Parse(Console.ReadLine());
                var sValue = double.Parse(Console.ReadLine());

                currentSum = fValue + sValue;
                difference = Math.Abs(oldSum - currentSum);

                if (difference>maxDifference)
                {
                    maxDifference = difference;
                }

                sum += currentSum;
                oldSum = currentSum;
            }
            if (sum / n == currentSum)
            {
                Console.WriteLine($"Yes, value={currentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
        }
    }
}
