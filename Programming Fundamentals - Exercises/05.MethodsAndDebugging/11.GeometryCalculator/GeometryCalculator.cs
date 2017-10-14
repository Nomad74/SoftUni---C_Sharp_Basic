using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main()
        {
            string figureType = Console.ReadLine();

            if(figureType=="triangle")
            {
                TriangleArea();
            }
            else if(figureType=="square")
            {
                SquareArea();
            }
            else if(figureType=="rectangle")
            {
                RectangleArea();
            }
            else
            {
                CircleArea();
            }
        }

        private static void CircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * radius * radius;
            Console.WriteLine($"{circleArea:f2}");
        }

        private static void RectangleArea()
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double rectangleArea = (widht * height);
            Console.WriteLine($"{rectangleArea:f2}");
        }

        private static void SquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double squareArea = (side * side);
            Console.WriteLine($"{squareArea:f2}");
        }

        private static void TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double triangleArea = (side * height) / 2;
            Console.WriteLine($"{triangleArea:f2}");
        }
    }
}
