using System;

namespace _01.OddOccurrences1
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace _01.OddOccurrences
    {
        class OddOccurrences
        {
            static void Main(string[] args)
            {
                var input = Console.ReadLine().ToLower().Split(' ').ToArray();
                Dictionary<string, int> inputToDict = new Dictionary<string, int>();

                foreach (var word in input)
                {
                    if (inputToDict.ContainsKey(word))
                    {
                        inputToDict[word]++;
                    }
                    else
                    {
                        inputToDict[word] = 1;
                    }
                }
                var result = new List<string>();

                foreach (var word in inputToDict)
                {
                    if (word.Value % 2 != 0)
                    {
                        result.Add(word.Key);
                    }
                }
                Console.WriteLine(string.Join(", ", result));
            }
        }
    }

