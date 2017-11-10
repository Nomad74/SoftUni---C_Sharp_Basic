using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 2 * n;  double rightSum = 0; double leftSum=0;  

            for (int i = 1; i<=n; i++)
            {
                var leftNum = double.Parse(Console.ReadLine());

                leftSum = leftSum + leftNum;
            }
            for (int a = (n+1); a <= (2*n); a++)
            {
                var rightNum = double.Parse(Console.ReadLine());

                rightSum = rightSum + rightNum;
            }

            double r = Math.Abs(leftSum - rightSum);

            if (r==0)
            {
                Console.WriteLine("Yes, sum = "+rightSum);
            }
            else
            {
                Console.WriteLine("No, diff = "+r);
            }
        }
    }
}
