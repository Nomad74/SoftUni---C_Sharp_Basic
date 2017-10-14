using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parallelepiped
{
    class Parallelepiped
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var dots = (n * 2) + 1; 
            string waves =new string(('~'),(n-2)) ;

            Console.Write("+"+ waves+ "+");
            Console.WriteLine(new string('.',dots));
            var col = dots;   string line = @"\";  string line2 = @"|";

              for (int i = 1; i <= col; i++)
              {
                dots -= 1;
               Console.Write("|"+new string('.',i-1));
               Console.Write(line+waves+line);
               Console.WriteLine(new string('.', dots));
              }
               dots = (n * 2) + 1;

            for (int i = 0; i < (n * 2) + 1; i++)
            {
                dots -= 1;
                Console.Write(new string('.', i));
                Console.Write(line);
                Console.Write(new string('.', (n * 2) - i));
                Console.WriteLine(line2 + waves + line2);
            }
            
            Console.Write(new string('.', (n*2)+1));
            Console.WriteLine("+" + waves + "+");


        }
    }
}
