using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int br = 1;
            var resources = new Dictionary<string, string>();
            string m = "";

            while (a != "stop")
            {
                if (br % 2 != 0)
                {
                    m = a;
                }

                else
                {
                    string str;
                    if (resources.TryGetValue(m, out str))
                    {
                        resources[m] = a;
                    }

                    else
                    {
                        resources.Add(m, a);
                    }
                }

                br++;
                a = Console.ReadLine();
            }

            foreach (var item in resources.Keys)
            {
                Console.WriteLine($"{item} -> {resources[item]}");
            }
        }
    }
}
