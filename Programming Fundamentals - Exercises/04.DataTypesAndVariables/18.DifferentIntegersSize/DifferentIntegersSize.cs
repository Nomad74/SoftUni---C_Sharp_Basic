using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main()
        {
            string input = Console.ReadLine();

            try
            {
                long integer = long.Parse(Console.ReadLine());
                Console.WriteLine($"{integer} can fit in:");
            }
            catch (OverflowException)
            {

            }
            try
            {
                sbyte integer = sbyte.Parse(Console.ReadLine());
                Console.WriteLine("* sbyte");
            }
            catch (OverflowException)
            {

            }
            try
            {
                byte integer = byte.Parse(Console.ReadLine());
                Console.WriteLine("* byte");
            }
            catch (OverflowException)
            {

            }
            try
            {
                short integer = short.Parse(Console.ReadLine());
                Console.WriteLine("* short");
            }
            catch (OverflowException)
            {

            }
            try
            {
                ushort integer = ushort.Parse(Console.ReadLine());
                Console.WriteLine("* ushort");
            }
            catch (OverflowException)
            {

            }
            try
            {
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine("* int");
            }
            catch (OverflowException)
            {

            }
            try
            {
                uint integer = uint.Parse(Console.ReadLine());
                Console.WriteLine("* uint");
            }
            catch (OverflowException)
            {

            }
            try
            {
                long integer = long.Parse(Console.ReadLine());
                Console.WriteLine("* int");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
