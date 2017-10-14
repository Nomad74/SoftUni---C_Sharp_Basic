using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_Powers_of_2
{
    class EvenPowers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int num = 1;

            for(int i=0; i<=n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num = num * 2;
            }
        }
    }
}
