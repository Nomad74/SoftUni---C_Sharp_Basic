using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
               input = "";

            while((commands != "Even")||(commands != "Odd"))
            {
                input = Console.ReadLine();
                string[] commands = input.Split();

                if (commands=="Delete")
                {
                    foreach()
                }
                else if (commands == "Insert")
                {
                    foreach ()
                }
                commands = Console.ReadLine();

            }
            if (commands=="Even")
            {

            }
            else if (commands == "Odd")
            {

            }
        }
    }
}
