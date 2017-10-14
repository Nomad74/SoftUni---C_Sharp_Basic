using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WorldRecord
{
    class WorldRecord
    {
        static void Main()
        {
            var recordS = double.Parse(Console.ReadLine());
            var distanceM = double.Parse(Console.ReadLine());
            var timeSforM = double.Parse(Console.ReadLine());

            var swwim = distanceM * timeSforM;
            var zab =(int)( distanceM / 15.0);

            var zab2=zab    * 12.5;
            var sumTime = swwim + zab2;

            if(sumTime<=recordS)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {sumTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(sumTime-recordS):f2} seconds slower.");
            }


        }
    }
}
