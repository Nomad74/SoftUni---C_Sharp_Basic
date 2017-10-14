using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_on_Segment
{
    class PointOnSegment
    {
        static void Main()
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var point = double.Parse(Console.ReadLine());

            double dif = 0;

            double start = Math.Min(first, second);
            double end = Math.Max(first, second);

           

            if(point>=start && point<=end)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            if ((Math.Abs( start - point)) <= (Math.Abs( end - point)))
            {
                dif = Math.Abs( start - point);
            }
            else
            {
                dif = Math.Abs( end - point);
            }
            Console.WriteLine(dif);
        }
    }
}
