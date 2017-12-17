using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Raincast
{
    class Raincast
    {
        static void Main()
        {
            var forecast = new Dictionary<string, Dictionary<string, List<string>>>();
            var sequence = new List<string>();
            var lastSeq = new List<string>();
            string input = "";

            while (input != "Davai Emo")
            {
                input = Console.ReadLine();
                sequence = input.Split(' ').ToList();
                var type = sequence[1];
                

                if ((sequence[0] == "Type:")&&(type=="Normal"||type== "Warning" || type== "Danger"))
                {
                    type = sequence[1];
                    forecast[type] = new Dictionary<string, List<string>>();
                }
                else if (sequence[0] == "Source:" && forecast.ContainsKey(type))
                {
                    source1 = sequence[0];
                    source = sequence[1];
                }
                else if (sequence[0] == "Forecast:" && forecast.ContainsKey(type) && source1 == "Forecast:")
                {
                    foreach (var item in sequence)
                    {
                        forecast[type].Add(source, item);
                    }
                }
            }
        }
    }
}
