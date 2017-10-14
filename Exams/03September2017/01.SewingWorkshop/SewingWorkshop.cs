using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SewingWorkshop
{
    class SewingWorkshop
    {
        static void Main()
        {
            var numbTable = double.Parse(Console.ReadLine());
            var lengthTable = double.Parse(Console.ReadLine());
            var widthTable = double.Parse(Console.ReadLine());

            double sizeCovers = (lengthTable+0.60)*(widthTable+0.60);
            double sizeCarpets = (lengthTable / 2)*(lengthTable / 2);

            var m2TextilCovers = numbTable * sizeCovers;
            var m2TextilCarpets = numbTable * sizeCarpets;

            var priceTextilCoversD = 7 * m2TextilCovers;
            var priceTextilCarpetsD = 9 * m2TextilCarpets;

            var sumD = priceTextilCoversD + priceTextilCarpetsD;

            Console.WriteLine($"{sumD:f2} USD");
            Console.WriteLine($"{(sumD*1.85):f2} BGN");

        }
    }
}
