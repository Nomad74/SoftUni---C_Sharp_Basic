using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Point_in_Figure
{
    class PointInFigure
    {
        static void Main()
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            
           

           
           
           if (((x >= 4 && x <= 10) && (y >= -5 && y <= -3)) || ((x >= -3 && x <= 12) && (y >= -3 && y <= 1))  ||
               ((x >= 4 && x <= 10) && (y >= 1 && y <= 3)))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
