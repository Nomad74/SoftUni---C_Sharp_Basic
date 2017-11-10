using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] array = new bool[n];

            for (int i = 2; i < n; i++)
            {
                array[i] = true;
            }
            array[0] = false;   array[1] = false;


        }
    }
}
