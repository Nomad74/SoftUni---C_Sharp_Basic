using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var dict = new Dictionary<int, string>();
            Random rnd = new Random();
            dict[0] = words[rnd.Next(0, words.Length)];

            for (int i = 0; i <words.Length; i++)
            {
                int randomNum = rnd.Next(0, words.Length);

                if(dict[i] != words[randomNum])
                {
                    dict[i] = words[randomNum];
                }
                else
                {
                    i--;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
