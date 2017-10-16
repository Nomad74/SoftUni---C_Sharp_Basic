using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            
            int longest = 0; int position = 0; int maxLongest = 0;  int leftPosition = 0; string equalSequence = "";

            for (int i = 0; i <array.Length; i++)
            {
                if(array[i]==array[i+1])
                {
                    equalSequence = equalSequence + array[i];
                    longest++ ;
                    position=i ;
                }
                maxLongest = Math.Max(maxLongest, longest);
                leftPosition = Math.Max(leftPosition, position);
            }
        }
    }
}
