using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Rainer
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var original = sequence;
            int index = (sequence.Count) - 1;
            sequence.RemoveAt(index);
            int donaldSteps;

            var initialIndex = sequence.Last();

            
            var count = 0;  var count2 = 0;

            while (true)
            {
                if (count != 0)
                {
                   donaldSteps = int.Parse(Console.ReadLine());
                    count2++;
                }
                else
                {
                  donaldSteps = initialIndex;
                    count = 1;
                }

                for (int i = 0; i < sequence.Count; i++) //min-1
                {
                    sequence[i] = sequence[i] - 1;
                   
                }

                if (sequence[donaldSteps] == 0)
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] == 0)
                        {
                            sequence[i] = original[i];
                        }
                    }
                }
            }
           
            Console.WriteLine(string.Join(" ", sequence));
            Console.WriteLine(count2);  
        }
    }
}
