using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DebitCardNumber
{
    class Program
    {
        static void Main()
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            var fourth = int.Parse(Console.ReadLine());

            Console.WriteLine($"{first:D4} { second:d4} {third:D4} {fourth:D4}");
        }
    }
}
