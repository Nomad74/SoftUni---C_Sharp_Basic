using System;

class AreaOfFigures
{
    static void Main()
    {
        string figurе = Console.ReadLine();

        if (figurе == "square")
        {
            var a = double.Parse(Console.ReadLine());
            double area = (a*a);
            Console.WriteLine(Math.Round(area, 3));
        }
        else if (figurе == "rectangle")
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            double area = (a * b);
            Console.WriteLine(Math.Round(area, 3));
        }
        else if (figurе == "circle")
        {
            var r = double.Parse(Console.ReadLine());
            double area = (Math.PI*r * r);
            Console.WriteLine(Math.Round(area, 3));
        }
        else
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            double area = (a * h) / 2;
            Console.WriteLine(Math.Round(area,3));
        }
    }
}
