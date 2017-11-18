using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Resurrection
{
    class Resurrection
    {
        static void Main(string[] args)
        {

            double totalYears = 0.0; int n = 0;
            double totalLength = 0.0; double totalWidth = 0.0; double lengthOfOneWing = 0.0;

            int amountOfFoenixes = int.Parse(Console.ReadLine());
            double[] printTotalYears = new double[amountOfFoenixes];

            InputDataToArray(ref totalYears, ref totalLength, ref totalWidth, ref lengthOfOneWing, amountOfFoenixes, printTotalYears);

            n = Accuracy(n, totalWidth);
            for (int i = 0; i < amountOfFoenixes; i++)
            {
                Console.WriteLine($"{decimal.Round((decimal)(printTotalYears[i]), n)}");
            }
        }

        private static void InputDataToArray(ref double totalYears, ref double totalLength, ref double totalWidth, ref double lengthOfOneWing, int amountOfFoenixes, double[] printTotalYears)
        {
            for (int i = 0; i < amountOfFoenixes; i++)
            {
                totalLength = double.Parse(Console.ReadLine());
                totalWidth = double.Parse(Console.ReadLine());
                lengthOfOneWing = double.Parse(Console.ReadLine());

                totalYears = (totalLength * totalLength) * (totalWidth + 2 * lengthOfOneWing);
                printTotalYears[i] = totalYears;
            }
        }

        private static int Accuracy(int n, double totalWidth)
        {
            var accuracy = totalWidth;
            while (accuracy != (int)(accuracy))
            {
                accuracy *= 10;
                n++;
            }

            return n;
        }
    }
}
