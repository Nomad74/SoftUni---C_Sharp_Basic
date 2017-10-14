using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Price
{
    class Price
    {
        static void Main()
        {
            var pieces = int.Parse(Console.ReadLine());
            var priceDot= double.Parse(Console.ReadLine());

            int [] area = new int [pieces];  double sum = 0; double sumOv = 0;

            for(int i =0; i<area.Length; i++)
            {
                area [i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < area.Length; i++)
            {
                if(i%2!=0)
                {
                    sum = area[i] * 2;
                }
                else
                {
                    sum = area[i];
                }
                sumOv = sumOv + sum;
            }
            double price = sumOv * priceDot;

            Console.WriteLine($"The project prize was {price:f2} lv.");
        }
    }
}
