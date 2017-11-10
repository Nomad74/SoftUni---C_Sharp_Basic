using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.IntegerTypes
{
    class IntegerTypes
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = long.Parse(Console.ReadLine());
            var thirdNum = long.Parse(Console.ReadLine());
            var fourthNum = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum} {secondNum} {thirdNum} {fourthNum}");
        }
    }
}
