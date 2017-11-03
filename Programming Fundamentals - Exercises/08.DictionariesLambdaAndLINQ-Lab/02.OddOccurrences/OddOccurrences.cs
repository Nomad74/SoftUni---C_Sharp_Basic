using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var count = new Dictionary<string, int>();
            var input = Console.ReadLine().ToLower().Split(' ').ToList();

            foreach (string word in input)
            {
                if (count.ContainsKey(word))
                {
                    count[word] += 1;
                }
                else
                {
                    count.Add(word, 1);
                }
            }
            var oddValue = new List<string>();
            foreach (KeyValuePair<string, int> item in count)
            {
                if ( item.Value % 2 != 0 )
                {
                    oddValue.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", " , oddValue));
        }
    }
}
