using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Email
{
    class Email
    {
        static void Main(string[] args)
        {
            var email = new Dictionary<string, string>();
            string input = "";  int count = 1;   string name = "";

            while(input!="stop")
            {
                input = Console.ReadLine();
                if (count %2 != 0)
                {
                    name = input;
                }
                else
                {
                    input = input.ToLower();
                    if (!input.EndsWith("us")|| !input.EndsWith("uk"))
                    {
                        email[name] = input;
                    }
                }
                count++;
            }
            foreach (var item in email)
            {
                Console.WriteLine($"{item.Key} – > {item.Value}");
            }
        }
    }
}
