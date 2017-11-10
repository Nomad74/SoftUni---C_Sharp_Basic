using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var number= Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            number = number.OrderByDescending(num => num).Take(3).ToList();
            Console.WriteLine(string.Join(", ", number));
        }
    }
}
