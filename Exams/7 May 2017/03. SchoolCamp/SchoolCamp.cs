using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SchoolCamp
{
    class SchoolCamp
    {
        static void Main()
        {
            var winterBoysGirls = 9.60;  var spingBoysGirls = 7.20;  var summerBoysGirls = 15;
            var winterMixed = 10.00; var springMixed = 9.50; var summerMixed = 20;

            var season = Console.ReadLine();  //winter, summer..
            var group = Console.ReadLine();  //boys girls....
            var numbSch = int.Parse(Console.ReadLine());
            var numOverNight = int.Parse(Console.ReadLine());

            double price = 0;  string sport = "Swimming";

            if (season == "Winter")
            {
                if (group == "boys")
                {
                    price = winterBoysGirls * numbSch * numOverNight;
                    sport = "Judo";
                }
                else if(group == "girls")
                {
                    price = winterBoysGirls * numbSch * numOverNight;
                    sport = "Gymnastics";
                }
                else
                {
                    price = winterMixed * numbSch * numOverNight;
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (group == "boys")
                {
                    price = spingBoysGirls * numbSch * numOverNight;
                    sport = "Tennis";
                }
                else if(group == "girls")
                {
                    price = spingBoysGirls * numbSch * numOverNight;
                    sport = "Athletics";
                }
                else
                {
                    price = springMixed * numbSch * numOverNight;
                    sport = "Cycling";
                }
            }
            else
            {
                if (group == "boys")
                {
                    price = summerBoysGirls * numbSch * numOverNight;
                    sport = "Football";
                }
                else if(group == "girls")
                {
                    price = summerBoysGirls * numbSch * numOverNight;
                    sport = "Volleyball";
                }
                else
                {
                    price = summerMixed * numbSch * numOverNight;
                    sport = "Swimming";
                }
            }

            if(numbSch>=10 && numbSch<20)
            {
                price = price - (price * 0.05);
            }
            else if(numbSch >= 20 && numbSch < 50)
            {
                price = price - (price * 0.15);
            }
            else if(numbSch >= 50)
            {
                price = price - (price * 0.50);
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
