using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FootballLeague
{
    class FootballLeague
    {
        static void Main()
        {
            double capacity = int.Parse(Console.ReadLine());
            double numbFan = int.Parse(Console.ReadLine());

            var sumA = 0; var sumB = 0; var sumV = 0; var sumG = 0;

            for (int i = 1; i <= numbFan; i++)
            {
                var sector = Console.ReadLine();

                if (sector == "A")
                {
                    sumA = sumA + 1;
                }
                else if (sector == "B")
                {
                    sumB = sumB + 1;
                }
                else if (sector == "V")
                {
                    sumV = sumV + 1;
                }
                else
                {
                    sumG = sumG + 1;
                }
            }
                
                double prA= ((sumA / numbFan) * 100.00);
                double prB = ((sumB / numbFan) * 100.00);
                double prV = ((sumV / numbFan) * 100.00);
                double prG = ((sumG / numbFan) * 100.00);
                double prCap= ((numbFan / capacity) * 100.00);

            Console.WriteLine($"{prA:f2}%");
                Console.WriteLine($"{prB:f2}%");
                Console.WriteLine($"{prV:f2}%");
                Console.WriteLine($"{prG:f2}%");
                Console.WriteLine($"{prCap:f2}%");

            
        }
    }
}
