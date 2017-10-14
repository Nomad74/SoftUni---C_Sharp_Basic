using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NumberTable
{
    class NumberTable
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                for(int col=1; col<=n; col++)
                {
                    var num = i + col;
                    
                    if (num>n)
                    {
                        num = n-(num % n);
                    }
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
