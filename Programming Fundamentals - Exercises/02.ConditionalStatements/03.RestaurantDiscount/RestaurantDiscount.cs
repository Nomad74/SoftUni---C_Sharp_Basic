using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main()
        {
            double groupSize = double.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double totalPrice = 0;   double price = 0;  double discount = 0;
            string hallName = "appropriate"; double hallPrice = 0;  double packagePrice = 0;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            if (groupSize<=50)
            {
                hallName = "Small Hall";   hallPrice = 2500;
                if (package=="Normal")
                {
                    packagePrice = 500; 
                    totalPrice = hallPrice + packagePrice;
                    discount = totalPrice - (totalPrice * 5 / 100);
                    price = discount / groupSize;
                }
                else if (package == "Gold")
                {
                    packagePrice = 750;
                    totalPrice = hallPrice + packagePrice;
                    discount = totalPrice - (totalPrice * 10 / 100);
                    price = discount / groupSize;
                }
                else
                {
                    packagePrice = 1000;
                    totalPrice = hallPrice + packagePrice;
                    discount = totalPrice - (totalPrice * 15 / 100);
                    price = discount / groupSize;
                }
            }
            else if ((groupSize > 50)&&(groupSize<=100))
            {
                hallName = "Terrace"; hallPrice = 5000;
                if (package == "Normal")
                {
                    packagePrice = 500;
                    totalPrice = hallPrice + packagePrice;
                    discount = totalPrice - (totalPrice * 5 / 100);
                    price = discount / groupSize;
                }
                else if (package == "Gold")
                {
                    packagePrice = 750;
                    totalPrice = hallPrice + packagePrice;
                    discount = totalPrice - (totalPrice * 10 / 100);
                    price = discount / groupSize;
                }
                else
                {
                    packagePrice = 1000;
                    totalPrice = hallPrice + packagePrice;
                    discount = totalPrice - (totalPrice * 15 / 100);
                    price = discount / groupSize;
                }
            }
            else if ((groupSize > 100) && (groupSize <= 120))
            {
                hallName = "Great Hall"; hallPrice = 7500;
                if (package == "Normal")
                {
                    packagePrice = 500;
                    totalPrice = hallPrice + packagePrice;
                    discount = totalPrice - (totalPrice * 5 / 100);
                    price = discount / groupSize;
                }
                else if (package == "Gold")
                {
                    packagePrice = 750;
                    totalPrice = hallPrice + packagePrice;
                    discount = totalPrice - (totalPrice * 10 / 100);
                    price = discount / groupSize;
                }
                else
                {
                    packagePrice = 1000;
                    totalPrice = hallPrice + packagePrice;
                    discount = totalPrice - (totalPrice * 15 / 100);
                    price = discount / groupSize;
                }
            }

            if (hallName != "appropriate")
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {price:f2}$");
            }
        }
    }
}
