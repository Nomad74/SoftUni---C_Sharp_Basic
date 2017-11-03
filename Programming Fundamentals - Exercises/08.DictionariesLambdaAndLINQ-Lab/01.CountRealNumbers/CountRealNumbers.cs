using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var count = new SortedDictionary<double, int>();
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            foreach (var num in input)
            {
                if (count.ContainsKey(num))
                {
                    count[num] += 1;
                }
                else
                {
                    count.Add(num, 1);
                }
            }
            foreach (KeyValuePair<double, int> entry in count)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
            
        }
    }
}
