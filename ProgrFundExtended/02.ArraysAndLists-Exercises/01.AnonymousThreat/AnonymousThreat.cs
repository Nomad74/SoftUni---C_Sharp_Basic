using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            var input = new List<string>();
            var list = Console.ReadLine().Split(' ').ToList();

            while(input[0] == "3:1")
            {
                input = Console.ReadLine().Split(' ').ToList();
                string command = input[0];
                int startIndex = int.Parse(input[1]);
                int endIndex = int.Parse(input[2]);

                if (startIndex<0 || startIndex>list.Count-1)
                {
                    startIndex = 0;
                }
                if (endIndex<0 || endIndex>list.Count-1)
                {
                    endIndex = list.Count - 1;
                }

                switch (command)
                {
                    case "merge":
                        var elemCatenat = string.Join("", list.Skip(startIndex).Take(endIndex + 1).ToArray());
                        list.RemoveRange(startIndex, endIndex + 1);
                        list.Insert(startIndex, elemCatenat);
                        break;

                    case "divide":
                        int startIndexDivide = int.Parse(input[1]);
                        int particion = int.Parse(input[2]);

                        static List<string> divideEqual (string word, int divide)
                        {
                            List<string> result = new List<string>();
                            int partitionCount = word.Length / divide;

                            while (word.Length>=partitionCount)
                            {
                                result.Add(word.Substring(0, partitionCount));
                                word.Substring(partitionCount);

                            }


                        }

                        break;
                }
            }
        }
    }
}
