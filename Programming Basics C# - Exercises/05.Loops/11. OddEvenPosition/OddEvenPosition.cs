using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            double oddSum = 0.0; double evenSum =0.0;
            double minOdd = 0.0; double minEven = 0.0;
            double maxOdd = 0.0; double maxEven = 0.0;

            var n = int.Parse(Console.ReadLine());

            if ( n==0 )
            {
                Console.WriteLine($"OddSum={oddSum},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n==1)
            {
                var oddFirst = double.Parse(Console.ReadLine());
                oddSum = oddFirst; minOdd = oddFirst; maxOdd = oddFirst;

                Console.WriteLine($"OddSum={oddSum},");
                Console.WriteLine($"OddMin={minOdd},");
                Console.WriteLine($"OddMax={maxOdd},");
                Console.WriteLine($"EvenSum={evenSum},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                var oddFirst = double.Parse(Console.ReadLine());
                var evenFirst = double.Parse(Console.ReadLine());

                 oddSum = oddFirst;  evenSum = evenFirst;
                 minOdd = oddFirst;  minEven = evenFirst;
                 maxOdd = oddFirst;  maxEven = evenFirst;



                for ( int i = 1; i <= n-2; i++)
                {
                    var num = double.Parse(Console.ReadLine());

                    if (i % 2 != 0)
                    {
                        oddSum = oddSum + num;

                        if (num > maxOdd)
                        {
                            maxOdd = num;
                        }
                        else if (num < minOdd)
                        {
                            minOdd = num;
                        }
                    }
                    else
                    {
                        evenSum = evenSum + num;

                        if (num > maxEven)
                        {
                            maxEven = num;
                        }
                        else if (num < minEven)
                        {
                            minEven = num;
                        }
                    }
                }
                Console.WriteLine($"OddSum={oddSum},");
                Console.WriteLine($"OddMin={minOdd},");
                Console.WriteLine($"OddMax={maxOdd},");
                Console.WriteLine($"EvenSum={evenSum},");
                Console.WriteLine($"EvenMin={minEven},");
                Console.WriteLine($"EvenMax={maxEven}");
            }
            
        }
    }
}
