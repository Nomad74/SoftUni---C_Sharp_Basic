using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main()
        {
            double cubeLenght = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double faceDiagonals = 0; double spaceDiagonals = 0; double volume = 0; double area = 0;

            if(parameter=="face")
            {
                faceDiagonals = Math.Sqrt(2 * (cubeLenght * cubeLenght));
                Console.WriteLine($"{faceDiagonals:f2}");
            }
            else if(parameter=="space")
            {
                spaceDiagonals= Math.Sqrt(3 * (cubeLenght * cubeLenght));
                Console.WriteLine($"{spaceDiagonals:f2}");
            }
            else if(parameter=="volume")
            {
                volume = cubeLenght * cubeLenght * cubeLenght;
                Console.WriteLine($"{volume:f2}");
            }
            else
            {
                area = 6 * (cubeLenght * cubeLenght);
                Console.WriteLine($"{area:f2}");
            }
        }
    }
}
