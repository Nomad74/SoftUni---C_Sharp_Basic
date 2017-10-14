using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var widht = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            double area = height * widht;

            Console.WriteLine($"{area:f2}");
        }
    }
}
