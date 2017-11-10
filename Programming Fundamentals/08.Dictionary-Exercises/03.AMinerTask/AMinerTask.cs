using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var minerTask = new Dictionary<string, long>();
            var input = Console.ReadLine();

            int count = 1;  string resource = "";  long quantity = 0;

            while(input != "stop")
            {
                if(count %2 != 0)
                {
                    resource = input;
                }
                else
                {
                    quantity = long.Parse(input);

                    if (minerTask.ContainsKey(resource))
                    {
                        minerTask[resource] = minerTask[resource] + quantity;
                    }
                    else
                    {
                        minerTask[resource]= quantity;
                    }
                }
                count++;
                input = Console.ReadLine();
            }
            foreach (var item in minerTask)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
