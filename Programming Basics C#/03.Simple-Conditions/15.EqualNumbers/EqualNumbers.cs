using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.EqualNumbers
{
    class EqualNumbers
    {
        static void Main(string[] args)
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondtNumber = double.Parse(Console.ReadLine());
            var thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber == secondtNumber)
            {
                if (secondtNumber == thirdNumber)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
