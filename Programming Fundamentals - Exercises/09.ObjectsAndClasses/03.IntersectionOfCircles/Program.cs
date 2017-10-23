
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp18
{
    class Program
    {
        class Circle
        {


            public int CenterPointX { get; set; }
            public int CenterPointY { get; set; }
            public int Radius { get; set; }


            class Point
            {
                public int X { get; set; }
                public int Y { get; set; }
            }

            static bool Intersection()
            {
                int[] circle1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int[] circle2 = Console.ReadLine().Split().Select(int.Parse).ToArray();


                Point p = new Point() { X = circle1[0], Y = circle1[1] };
                Point p2 = new Point() { X = circle2[0], Y = circle2[1] };

                int radiusalpha = circle1[2];
                int radiusbeta = circle2[2];

                Circle alpha = new Circle() { CenterPointX = p.X, CenterPointY = p.Y, Radius = radiusalpha };
                Circle beta = new Circle() { CenterPointX = p2.X, CenterPointY = p2.Y, Radius = radiusbeta };

                double sumofradiuses = alpha.Radius + beta.Radius;
                double Distance = Math.Sqrt(Math.Pow(alpha.CenterPointX - beta.CenterPointX, 2) + Math.Pow(alpha.CenterPointY - beta.CenterPointY, 2)); // Разстоянието се намира по Питагоровата теорема -> Math.Sqrt(a*a + b*b)

                if (Distance > sumofradiuses) // Ако Distance == sumofradiuses, се пресичат
                {
                    return false;
                }
                return true;
            }
            static void Main(string[] args)
            {

                if (Intersection() == true)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
