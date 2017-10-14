using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrainingLab
{
    class TrainingLab
    {
        static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var hight = double.Parse(Console.ReadLine());

            var row =(int) (width / 1.20);
            var col = (int)( (hight -1.00)/ 0.70);

            var places = (int)(row * col)-3;

            Console.WriteLine(places);
        }
    }
}
