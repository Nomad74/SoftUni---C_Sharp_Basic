using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RealNumberTypes
{
    class RealNumberTypes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n<16)
            {
                var numb = double.Parse(Console.ReadLine());
                Console.WriteLine(numb);
            }
            else if(n<29)
            {
                var numb = decimal.Parse(Console.ReadLine());
                Console.WriteLine(numb);
            }
        }
    }
}
