using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int factoriel = 1;
            for(int i=1; i<=n; i++)
            {
                factoriel = factoriel * i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
