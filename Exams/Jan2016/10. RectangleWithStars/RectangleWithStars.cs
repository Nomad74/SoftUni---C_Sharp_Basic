using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RectangleWithStars
{
    class RectangleWithStars
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('%',n*2));

            int row = 0; 

            if(n%2==0)
            {
                row = n - 1;
            }
            else
            {
                row = n;
            }

            int col = (row / 2) + 1;

            for (int i=1; i<=row; i++)
            {
                Console.Write("%");
                if (i == col)
                {
                    Console.Write(new string(' ', n - 2));
                    Console.Write("**");
                    Console.Write(new string(' ', n - 2));
                }
                else
                {
                    Console.Write(new string(' ', (n * 2) - 2));
                }
                 Console.WriteLine("%");
            }
            Console.WriteLine(new string('%', n * 2));
        }
    }
}
