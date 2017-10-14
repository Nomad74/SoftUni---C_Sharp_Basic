using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FruitCoctails
{
    class FruitCoctails
    {
        static void Main()
        {
            string fruit = Console.ReadLine();
            string sizeCoct = Console.ReadLine();
            var numbDrinks = double.Parse(Console.ReadLine());

            double price = 0;

            if (fruit == "Watermelon")
            {
                if (sizeCoct == "small")
                {
                    price = 2 * 56.0;
                }
                if (sizeCoct == "big")
                {
                    price = 5 * 28.70;
                }
            }
            else if (fruit == "Mango")
            {
                if (sizeCoct == "small")
                {
                    price = 2 * 36.66;
                }
                if (sizeCoct == "big")
                {
                    price = 5 * 19.60;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (sizeCoct == "small")
                {
                    price = 2 * 42.10;
                }
                if (sizeCoct == "big")
                {
                    price = 5 * 24.80;
                }
            }
            else
            {
                if (sizeCoct == "small")
                {
                    price = 2 * 20.0;
                }
                if (sizeCoct == "big")
                {
                    price = 5 * 15.20;
                }
            }
            double sum = price * numbDrinks;
            

            if(sum>1000)
            {
                sum = sum / 2.0;
            }
            else if (sum>=400 && sum<=1000)
            {
                sum = sum - sum * 0.15;
            }
            else
            {
                sum = sum;
            }

            Console.WriteLine($"{sum:f2} lv.");
            
        }
    }
}
