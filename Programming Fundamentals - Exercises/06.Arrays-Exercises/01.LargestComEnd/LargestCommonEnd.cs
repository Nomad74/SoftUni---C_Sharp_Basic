using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int leftRightCount = 0;  int rightLeftCount = 0;

            for (int i = 0; i < firstArray.Length && i<secondArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                    leftRightCount++;
            }
            for (int j = 0; j < firstArray.Length && j < secondArray.Length; j++)
            {
                if (firstArray[firstArray.Length-1-j]==secondArray[secondArray.Length-1-j])
                {
                    rightLeftCount++;
                }
            }
            if (leftRightCount!=0 || rightLeftCount!=0)
            {
                Console.WriteLine(Math.Max(rightLeftCount,leftRightCount));
            }
            else
            {
                Console.WriteLine("No common words at the left and right");
            }
        }
    }
}
