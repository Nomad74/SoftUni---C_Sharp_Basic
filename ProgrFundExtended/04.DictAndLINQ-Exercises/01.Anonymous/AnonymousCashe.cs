using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous
{
    class AnonymousCashe
    {
        static void Main()
        {
            var anonymousData = new Dictionary<string, Dictionary<string, long>>();
            var validDataSet = new List<string>();
            var input = new string[3];

            while (input[0] != "thetinggoesskrra")
            {
                input = Console.ReadLine().Split(new[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input.Length > 1)
                {
                    var dataSet = input[2];
                    var dataKey = input[0];
                    var dataSizes = long.Parse(input[1]);

                    if (!anonymousData.ContainsKey(dataSet))
                    {
                        anonymousData[dataSet] = new Dictionary<string, long>();
                        if (!anonymousData[dataSet].ContainsKey(dataKey))
                        {
                            anonymousData[dataSet].Add(dataKey, dataSizes);
                        }
                        else
                        {
                            anonymousData[dataSet][dataKey] = dataSizes;
                        }
                    }
                    else
                    {
                        if (!anonymousData[dataSet].ContainsKey(dataKey))
                        {
                            anonymousData[dataSet].Add(dataKey, dataSizes);
                        }
                        else
                        {
                            anonymousData[dataSet][dataKey] = dataSizes;
                        }
                    }
                }
                else if (input[0] != "thetinggoesskrra")
                {
                        validDataSet.Add(input[0]);
                }
            }
            foreach (var item in anonymousData.Keys)
            {
                if (!validDataSet.Contains(item))
                {
                    anonymousData.Remove(item);
                }
            }
            var bigestSum = anonymousData.OrderByDescending(x => x.Value.Sum(e => e.Value)).First();
            var bigestDataSize = bigestSum.Value.Sum(e => e.Value);
  
            Console.WriteLine($"Data Set: {bigestSum.Key}, Total Size: {bigestDataSize}");
            foreach (var key in bigestSum.Value)
            {
                var data = key.Key;
                Console.WriteLine($"$.{data}");
            }
        }
    }
}
