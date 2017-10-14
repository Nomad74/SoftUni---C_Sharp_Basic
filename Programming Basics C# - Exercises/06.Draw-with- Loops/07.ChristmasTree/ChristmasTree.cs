using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i<=n+1; i++ )
            {
                Console.Write(new string(' ',(n+1)-i));
                Console.Write(new string('*',i-1));
                Console.Write(" | ");
                Console.Write(new string('*', i-1));
                Console.WriteLine();
            }
        }
    }
}
