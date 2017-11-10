using System;

class PointInTheFigure
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int x1 = h;       int y1 = 4 * h;
        int x2 = 2 * h;   int y2 = h;

        int x3 = 0;     int y3 = h;
        int x4 = 3 * h; int y4 = 0;

        int x5 = h;     int y5 = h;

        if (((x > x1 && x < x2) && (y < y1 && y > y2)) || ((x > x3 && x < x4) && (y < y3 && y > y4)) || ((x>x5 && x<x2) && (y==y5)))
        {
            Console.WriteLine("inside");
        }

        else if (  ((x >= x1 && x <= x2) && (y == y1)) || ((y <= y1 && y>=y2) && (x==x1 || x==x2)) || 


                (((x >= x3 && x <= x5)||(x>=x2 && x<=x4)) && (y == y3))  ||

                ((x >=x3 && x <=x4) && (y==y4)) || ((y <=y3 && y >= y4) && (x == x3 || x == x4)) )

            Console.WriteLine("border");


        else
        {
            Console.WriteLine("outside");
        }
    }
}
