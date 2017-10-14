using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                int digit = int.Parse(input);
                Console.WriteLine("digit");
            }
            catch (Exception)
            {
                if ("aouei".IndexOf(input) >= 0)
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}
