using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main(string[] args)
        {
            var priceWhisky = double.Parse(Console.ReadLine());
            var qBeer = double.Parse(Console.ReadLine());
            var qWine = double.Parse(Console.ReadLine());
            var qRakia = double.Parse(Console.ReadLine());
            var qWhisky = double.Parse(Console.ReadLine());

            
            double priceRakia = priceWhisky / 2.00;
            double priceWine = priceRakia - (0.40 * priceRakia);
            double priceBeer = priceRakia - (0.80 * priceRakia);

            double sumR = qRakia * priceRakia;
            double sumW = qWine * priceWine;
            double sumB = qBeer * priceBeer;
            double sumWh = qWhisky * priceWhisky;

            double sum = sumB + sumR + sumW + sumWh;

            Console.WriteLine("{0:f2}", sum);
        }
    }
}
