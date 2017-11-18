using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            double pokePower = double.Parse(Console.ReadLine());
            double distanceBetTarget = double.Parse(Console.ReadLine());
            double exhaustionFactor = double.Parse(Console.ReadLine());
            double numbTarg = 0; double intDivision = 0.0;

            while(pokePower>distanceBetTarget)
            {
                pokePower = pokePower - distanceBetTarget;
                numbTarg++;
                if (pokePower==distanceBetTarget)
                {
                    intDivision = pokePower / exhaustionFactor;
                }
            }
            if (intDivision!=0)
            {
                pokePower = intDivision;
            }
            Console.WriteLine(Math.Round(pokePower));
            Console.WriteLine(Math.Round(numbTarg));
        }
    }
}
