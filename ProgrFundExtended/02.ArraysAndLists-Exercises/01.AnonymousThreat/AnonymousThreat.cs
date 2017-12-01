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
            var commands = new string[3];
            var inputList = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "3:1")
            {
                commands = Console.ReadLine().Split(' ').ToArray();
                int startIndex = int.Parse(commands[1]);
                var endIndex = int.Parse(commands[2]);
                var concatList = "";
                var result = "";

                switch(commands[0])
                {
                    case "merge":

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatList += inputList[i];
                        }

                       result =string.Join((""), inputList.Skip(startIndex).Take(endIndex));

                        Console.WriteLine(string.Join(" ",result));

                        break;





                    case "divide":
                        break;
                }


            }




            Console.WriteLine(string.Join((" "),inputList));
            
        }
    }
}
