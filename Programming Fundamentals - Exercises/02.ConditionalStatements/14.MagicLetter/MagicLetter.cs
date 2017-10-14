using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class MagicLetter
    {
        static void Main()
        {
            char first = char.Parse( Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string contr = Console.ReadLine();

            for(char a=first; a<=second; a++)
            {
                for (char b = first; b <= second; b++)
                {
                    for (char c = first; c <= second; c++)
                    {
                        string result = $"{a}{b}{c} ";
                        if(!result.Contains(contr))
                        {
                            Console.Write(result);
                        }
                    }
                }
            }
        }
    }
}
