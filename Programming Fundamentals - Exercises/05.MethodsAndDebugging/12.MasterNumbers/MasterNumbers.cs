using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumbers
{
    class MasterNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                string s = i.ToString();
                if (SumOfDigits(i) && IsPalindrome(s) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool SumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }

            }
            return true;
        }
        static bool ContainsEvenDigit(int n)
        {
            int sum;
            int count = 1;

            while (n != 0)
            {
                sum = n % 10;
                n /= 10;
                if (sum % 2 == 0)
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
    }
}
