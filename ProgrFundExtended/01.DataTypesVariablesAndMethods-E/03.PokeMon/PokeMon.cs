using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            double pokePower = double.Parse(Console.ReadLine());
            double distanceBetTargint = double.Parse(Console.ReadLine());
            double exhaustionFactor = double.Parse(Console.ReadLine());
            int numbTarg = 0; double intDivision = 0.0;

            while(pokePower>distanceBetTargint)
            {
                pokePower = pokePower - distanceBetTargint;
                numbTarg++;
                if (pokePower==distanceBetTargint)
                {
                    intDivision = pokePower / exhaustionFactor;
                }
            }
            if (intDivision!=0)
            {
                pokePower = intDivision;
            }
            Console.WriteLine((int)pokePower);
            Console.WriteLine(numbTarg);
        }
    }
}
