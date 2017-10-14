using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class TheLongerLine
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lineOne = Line(x1, y1, x2, y2);
            double lineTwo = Line(x3, y3, x4, y4);

            if (lineOne >= lineTwo)
            {
                ClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                ClosestPoint(x3, y3, x4, y4);
            }
        }

        private static double Line(double x1, double y1, double x2, double y2)
        {
            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);
            double line = Math.Sqrt(a * a + b * b);
            return line;
        }

        public static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double hypOne = Math.Sqrt((x1 * x1) + (y1 * y1));
            double hypTwo = Math.Sqrt((x2 * x2) + (y2 * y2));

            if (hypOne <= hypTwo)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }

        }
    }
}
