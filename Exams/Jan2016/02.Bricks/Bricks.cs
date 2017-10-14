using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Bricks
    {
        static void Main()
        {
            var x = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            double s = x / (w * m);

            Console.WriteLine(Math.Floor(s));
        }
    }
}
