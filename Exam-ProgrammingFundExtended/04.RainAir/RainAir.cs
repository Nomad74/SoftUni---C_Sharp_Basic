using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class RainAir
    {
        static void Main()
        {
            var rainAir = new Dictionary<string, List<string>>();
            var input = "";
            var sequence = new List<string>();
            var result = new Dictionary<string, List<string>>();

            while (input!= "I believe I can fly!")
            {
                input = Console.ReadLine();
                sequence = input.Split(' ').ToList();

                var customerName = sequence[0];

                if (!rainAir.ContainsKey(customerName))
                {
                    rainAir[customerName] = new List<string>();
                    if (sequence[1] != "=")
                    {
                        sequence.Remove(customerName);
                        foreach (var item in sequence)
                        {
                            rainAir[customerName].Add(item);
                        }
                    }
                    else
                    {
                        var newName = sequence[2];
                        rainAir[customerName] = rainAir[newName];
                    }
                }
                else
                {
                    sequence.Remove(customerName);
                    foreach (var item in sequence)
                    {
                        rainAir[customerName].Add(item);
                    }
                }

                result = rainAir.OrderBy(x=>x.Key);
            }
            
        }
    }
}
