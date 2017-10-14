using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class House
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int star = 0;

            if (n%2==0)
            {
                star = 2;
            }
            else
            {
                star = 1;
            }

            for(int i=1; i<=(n+1)/2; i++) 
            {
                Console.Write(new string('-',(n-star)/2));
                Console.Write(new string('*',star));
                Console.WriteLine(new string('-', (n - star) / 2));
                star = star + 2;
            }
            for(int i=1; i<=n/2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*',n-2));
                Console.WriteLine("|");
            }
        }
    }
}
