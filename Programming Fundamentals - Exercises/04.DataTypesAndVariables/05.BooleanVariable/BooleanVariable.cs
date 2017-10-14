using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            string str= Console.ReadLine();
            bool conv = Convert.ToBoolean(str);
            if(conv==true)
            {
                Console.WriteLine("Yes");
            }
            if(conv==false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
