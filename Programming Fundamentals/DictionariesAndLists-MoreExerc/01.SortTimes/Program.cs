using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> houres = new SortedDictionary<int, string>();
            var input = Console.ReadLine().Split(' ',':').ToList();

            for (int i = 0; i < input.Count; i=i+2)
            {
                houres[i] = input[i]+input[i+1];
                Console.WriteLine($"{houres.Values}");
            }
            
        }
    }
}
