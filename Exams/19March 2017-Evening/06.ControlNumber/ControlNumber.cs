using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ControlNumber
{
    class ControlNumber
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var contr = int.Parse(Console.ReadLine());

            double sum=0;   int movs = 0;

            for(int fN=1; fN<=n; fN++)
            {
                for(int sN=m; sN>=1; sN--)
                {
                    sum = sum + (fN * 2) + (sN * 3);
                    movs += 1;
                    if (sum >= contr)
                        break;
                }
                if (sum >= contr)
                    break;
            }
            if (sum >= contr)
            {
                Console.WriteLine($"{movs} moves");
                Console.WriteLine($"Score: {sum} >= {contr}");
            }
            else
            {
                Console.WriteLine($"{movs} moves");
            }
        }
    }
}
