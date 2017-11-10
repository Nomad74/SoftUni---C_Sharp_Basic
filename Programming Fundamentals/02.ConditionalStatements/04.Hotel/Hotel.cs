using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceStudio = 0; double priceDouble = 0; double priceSuite = 0;

            if((month== "May")||(month == "October"))
            {
                priceStudio = 50.00; priceDouble = 65.00; priceSuite = 75.00;

                if (nightsCount>7)
                {
                    priceStudio *=0.95;
                    if(month == "October")
                    {
                        priceStudio = (priceStudio / nightsCount) * (nightsCount - 1);
                    }
                }
            }
            else if ((month == "June") || (month == "September"))
            {
                priceStudio = 60.00; priceDouble = 72.00; priceSuite = 82.00;
                if (nightsCount > 14)
                {
                    priceDouble *= 0.90;
                }
                if((nightsCount>7)&&(month == "September"))
                {
                    priceStudio = (priceStudio / nightsCount) * (nightsCount - 1);
                }
            }
            else if ((month == "July") || (month == "August") || (month == "December"))
            {
                priceStudio = 68.00; priceDouble = 77.00; priceSuite = 89.00;
                if (nightsCount > 14)
                {
                    priceSuite*=0.85;
                }
            }
            Console.WriteLine($"Studio: {(nightsCount * priceStudio):f2} lv.");
            Console.WriteLine($"Double: {(nightsCount*priceDouble):f2} lv.");
            Console.WriteLine($"Suite: {(nightsCount * priceSuite):f2} lv.");
        }
    }
}
