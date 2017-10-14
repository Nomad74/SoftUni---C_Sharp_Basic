using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DifferentNumbers
{
    class DifferentNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if ((b - a) < 5)
            {
                Console.WriteLine("No");
            }
            else
            { 
                for(int i=a; i<=b-4; i++)
                {
                    for(int n2=a+1; n2<=b-3; n2++)
                    {
                        for (int n3 = a + 2; n3 <= b-2; n3++)
                        {
                            for (int n4 = a + 3; n4 <= b - 1; n4++)
                            {
                                for (int n5 = a + 4; n5 <= b; n5++)
                                {
                                    if ((i < n2) && (n2 < n3) && (n3 < n4) && (n4 < n5))
                                    {
                                        Console.WriteLine($"{i} {n2} {n3} {n4} {n5}");
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
