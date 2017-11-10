using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> initialList = Console
            .ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            List<int> bombNumbers = Console
              .ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            int bombNumber = bombNumbers[0];
            int power = bombNumbers[1];

            while (initialList.Contains(bombNumber))
            {
                int index = initialList.IndexOf(bombNumber);
                int lastPower = initialList.Count - index;
                if (index + power < initialList.Count)
                {
                    initialList.RemoveRange(index - power, power * 2 + 1);
                }
                else
                {
                    initialList.RemoveRange(index - power, power + lastPower);
                }

            }
            int totalSum = initialList.Sum(x => Convert.ToInt32(x));
            Console.WriteLine(totalSum);
        }
    
    }
}
