using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            char[] chOne = input[0].ToCharArray();
            char[] chSecound = input[1].ToCharArray();

            int subSum = 0;
            int totalSum = 0;
            int sum = 0;

            if (chOne.Length == chSecound.Length)
            {
                for (int i = 0; i < chOne.Length; i++)
                {
                    sum += chOne[i] * chSecound[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                if (chOne.Length > chSecound.Length)
                {
                    for (int i = 0; i < chOne.Length - chSecound.Length; i++)
                    {
                        subSum += chOne[i];
                    }
                    for (int i = 0; i < chSecound.Length; i++)
                    {
                        sum += chOne[i] * chSecound[i];
                    }
                }
                else if (chSecound.Length > chOne.Length)
                {
                    for (int i = 0; i < chSecound.Length - chOne.Length; i++)
                    {
                        subSum += chSecound[i];
                    }
                    for (int i = 0; i < chOne.Length; i++)
                    {
                        sum += chOne[i] * chSecound[i];
                    }
                }
                totalSum = sum + subSum;
                Console.WriteLine(totalSum);
            }
        }
    }
}
