using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheLastOne
{
    class TheLastOne
    {
        static void Main()
        {
            var contr = int.Parse(Console.ReadLine());

            int a = 0; int b = 0; int c = 0;  var count1 = 0; var count2 = 0;

            for ( a=1; a<=30; a++)
            {
                for ( b = 1; b <= 30; b++)
                {
                    for ( c = 1; c <= 30; c++)
                    {
                        if ((a > b && b > c) && (a * b * c == contr))
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {contr}");
                            count1 = count1 + 1;
                        }
                        if ((a < b && b < c) && (a + b + c == contr))
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {contr}");
                            count2 = count2 + 1;
                        }





                    }
                }
            }
            
           
            if ((count1 == 0) && (count2 == 0)) Console.WriteLine("No!");

        }
    }
}
