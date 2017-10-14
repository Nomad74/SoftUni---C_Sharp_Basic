using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int firstNum = int.Parse(Console.ReadLine());

            int maxNum = firstNum; int sum = firstNum; 

            for (int i = 1; i <= n - 1; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num > maxNum)
                {
                    maxNum = num;
                }

                sum = sum + num;
                
            }

            int midSum = sum - maxNum;

            if (midSum==maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+maxNum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+Math.Abs(midSum-maxNum));
            }

        }
    }
}
