using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexFormat
{
    class ProgrVariableInHexFormatam
    {
        static void Main()
        {
            string hexa = Console.ReadLine();
            double num = Convert.ToInt32(hexa, 16);
            Console.WriteLine(num);
        }
    }
}
