using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TriangleArea
{
    class TriangleArea
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            double h = Math.Abs( y1 - y3);

            double a = Math.Abs(  x2 - x3);

            double area = a * h / 2.0;

            Console.WriteLine(area);


        }
    }
}
