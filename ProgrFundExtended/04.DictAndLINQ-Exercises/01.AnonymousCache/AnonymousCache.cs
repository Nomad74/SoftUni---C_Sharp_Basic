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
                    anonymousCache[dataSet] = new Dictionary<string, int>();
                }
            }
            var resultDataKey = new List<string>();
            var dataKEY = new List<string>();
            var resultDataSet = "";
            var sum = 0; var dataSum = 0; var lastSum = 0;

            foreach (var dataSet in anonymousCache)
            {
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
                    resultDataSet = dataSET;
                    foreach(var item in dataKEY)
                    {
                        resultDataKey.Add(item);
                    }
                    lastSum = dataSum;
                    dataSum = 0;
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
