using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().Split().ToList();
            var commands = new List<string>();
            var result = new List<string>();

            while (commands[0] != "3:1")
            {
                commands = Console.ReadLine().Split(' ').ToList();

                switch (commands[0])
                {
                    case "merge":
                        result = Merge(inputString, int.Parse(commands[1]), int.Parse(commands[2]));
                        break;


                        string merged = string.Empty;
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex >= inputString.Count - 1)
            {
                endIndex = inputString.Count - 1;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                merged += inputString[i];
            }
        }
    }
}
