using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            string hexa=Convert.ToString(number,toBase:16);
            string upperHexa = hexa.ToUpper();
            string binary = Convert.ToString(number, toBase:2);

            Console.WriteLine(upperHexa);
            Console.WriteLine(binary);
        }
    }
}
