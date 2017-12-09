using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousCache
{
    class AnonymousCache
    {
        static void Main(string[] args)
        {
            var anonymousCache = new Dictionary<string, Dictionary<string, int>>();
            var input = new string[4];  

            while(input[0]!= "thetinggoesskrra")
            {
                input = Console.ReadLine().Split(' ').ToArray();

                if (input.Length > 2 )
                {
                    var dataKey = input[0];
                    var dataSize = int.Parse(input[2]);
                    var dataSet =  input[4];

                    if (!anonymousCache.ContainsKey(dataSet))
                    {
                        anonymousCache[dataSet] = new Dictionary<string, int>();
                        anonymousCache[dataSet][dataKey]= dataSize;
                    }
                    else
                    {
                        anonymousCache[dataSet][dataKey] = dataSize;
                    }
                }
                else if(input[0] != "thetinggoesskrra")
                {
                    var dataSet = input[0];
                    if (!anonymousCache.ContainsKey(dataSet))
                    {
                        anonymousCache[dataSet] = new Dictionary<string, int>();
                    }
                }
            }

            var resultDataKey = new List<string>();
            string resultDataSet = "";
            var lastSum = 0;
            

            foreach (var dataSet in anonymousCache)
            {
                
                var dataKEY = new List<string>();
                var dataSum = 0; var sum = 0;
                var dataSET = dataSet.Key;
                var dataKey = dataSet.Value;
                

                foreach (var dataSize in dataKey)
                {
                    dataKEY.Add(dataSize.Key);
                    var data = dataSize.Value;
                    sum += data;
                }
                dataSum = sum;
                sum = 0;
                if (dataSum>=lastSum)
                {
                    lastSum = dataSum;
                    resultDataSet = dataSET;
                    resultDataKey.Clear();
                    foreach (var item in dataKEY)
                    {
                        resultDataKey.Add(item);
                    }
                }
                
            }
            Console.WriteLine($"Data Set: {resultDataSet}, Total Size: {lastSum}");
            foreach (var item in resultDataKey)
            {
                Console.WriteLine($"$.{item}");
            }
        }
    }
}
