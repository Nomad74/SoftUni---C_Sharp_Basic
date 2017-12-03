using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonimaus
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = new string[3];

            var inputString = Console.ReadLine().Split(' ').ToArray();


            while (commands[0]!="3:1")
            {
                commands = Console.ReadLine().Split(' ').ToArray();

                var startIndex = int.Parse(commands[1]);
                var endIndex = int.Parse(commands[2]);

                switch (commands[0])
                {
                    case "merge":

                        for (int i = startIndex; i < endIndex; i++)
                        {

                        }

                    case "divide":
                }
            }
        }
    }
}
