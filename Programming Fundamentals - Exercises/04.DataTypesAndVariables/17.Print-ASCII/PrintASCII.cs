using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_ASCII
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for(int i=a; i<=b; i++)
            {
                Console.Write((char)i+" ");
            }
            Console.WriteLine();
        }
    }
}
