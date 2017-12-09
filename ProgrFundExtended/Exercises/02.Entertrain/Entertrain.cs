using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Entertrain
    {
        static void Main()
        {
            int locomotivePower = int.Parse(Console.ReadLine());
            List<int> wagonsWeght = new List<int>();
            int currentWagon;
            int averageWagon;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out currentWagon))
                {
                    wagonsWeght.Add(currentWagon);

                    if (wagonsWeght.Sum() > locomotivePower)
                    {
                        averageWagon = (int)wagonsWeght.Average();
                        wagonsWeght.Remove(wagonsWeght.Aggregate((x, y) => Math.Abs(x - averageWagon) < Math.Abs(y - averageWagon) ? x : y));
                    }
                }
                else
                {
                    break;
                }
            }
            wagonsWeght.Reverse();

            Console.WriteLine(string.Join(" ", wagonsWeght) + " " + locomotivePower);
        }
    }
}
