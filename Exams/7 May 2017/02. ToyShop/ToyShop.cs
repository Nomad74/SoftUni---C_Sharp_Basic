using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ToyShop
{
    class ToyShop
    {
        static void Main()
        {
            var price =   double.Parse(Console.ReadLine());
            var puzzels = double.Parse(Console.ReadLine());
            var purples = double.Parse(Console.ReadLine());
            var bears =   double.Parse(Console.ReadLine());
            var minions = double.Parse(Console.ReadLine());
            var trucks =  double.Parse(Console.ReadLine());

            var sumToys = purples + purples + bears + minions + trucks;

            var prPuzzels = puzzels * 2.60;
            var prPurples = purples * 3.00;
            var prBears = bears * 4.10;
            var prMinions = minions * 8.20;
            var prTrucks = trucks * 2.00;

            var sumPrice = prBears + prMinions + prPurples + prTrucks + prPuzzels;


            if(sumToys>=50)
            {
                sumPrice = sumPrice - (sumPrice / 4);
            }
            sumPrice = sumPrice - (sumPrice * 0.10);

            var diff = Math.Abs(sumPrice - price);

            if(sumPrice >= price)
            {
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diff:f2} lv needed.");
            }
        }

    }
}
