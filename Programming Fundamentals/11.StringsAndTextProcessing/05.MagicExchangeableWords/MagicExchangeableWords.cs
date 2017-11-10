using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            AreTheyExchangebles(input[0], input[1]);

        }

        private static void AreTheyExchangebles(string v1, string v2)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            int minLength = Math.Min(v1.Length, v2.Length);
            for (int i = 0; i < minLength; i++)
            {

                if (dict.ContainsKey(v1[i]))
                {
                    if (dict[v1[i]] != v2[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                else if (dict.ContainsValue(v2[i]))
                {
                    if (dict.FirstOrDefault(x => x.Value == v2[i]).Key
                        != v1[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                else
                {
                    dict[v1[i]] = v2[i];
                }

            }
            if (v1.Length > v2.Length)
            {
                for (int i = minLength; i < v1.Length; i++)
                {
                    if (v1[i] != v2[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    if (!dict.ContainsKey(v1[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
            else if (v2.Length > v1.Length)
            {
                for (int i = minLength; i < v2.Length; i++)
                {
                    if (!dict.ContainsValue(v2[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
            Console.WriteLine("true");
        }
    }
}
