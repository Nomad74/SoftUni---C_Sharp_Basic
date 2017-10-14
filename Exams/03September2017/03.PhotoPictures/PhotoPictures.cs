using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PhotoPictures
{
    class PhotoPictures
    {
        static void Main()
        {
            int numbPictures = int.Parse(Console.ReadLine());
            string formPictures = (Console.ReadLine());
            string wayOfOrdering = (Console.ReadLine());

            double price = 0;

            if (formPictures== "9X13")
            {
                if(numbPictures>=50)
                {
                    price = numbPictures * (0.16 - (0.16 * 5 / 100));
                }
                else
                {
                    price = numbPictures * 0.16;
                }
            }

            if (formPictures == "10X15")
            {
                if (numbPictures >= 80)
                {
                    price = numbPictures * (0.16 - (0.16 * 3 / 100));
                }
                else
                {
                    price = numbPictures * 0.16;
                }
            }

            if (formPictures == "13X18")
            {
                if (numbPictures < 50)
                {
                    price = numbPictures * 0.38;
                }
                else if ((numbPictures >= 50)&(numbPictures<=100))
                {
                    price = numbPictures * (0.38 - (0.38 * 3 / 100));
                }
                else
                {
                    price = numbPictures * (0.38 - (0.38 * 5 / 100));
                }
            }
            if (formPictures == "20X30")
            {
                if (numbPictures < 10)
                {
                    price = numbPictures * 2.90;
                }
                else if ((numbPictures >= 10) & (numbPictures <= 50))
                {
                    price = numbPictures * (2.90 - (2.90 * 7 / 100));
                }
                else
                {
                    price = numbPictures *( 2.90 - (2.90 * 9 / 100));
                }
            }
            if (wayOfOrdering== "online")
            {
                price = price - (price * 2 / 100);
                Console.WriteLine($"{price:f2}BGN");
            }
            else
            {
                Console.WriteLine($"{price:f2}BGN");
            }
        }


    }
}
