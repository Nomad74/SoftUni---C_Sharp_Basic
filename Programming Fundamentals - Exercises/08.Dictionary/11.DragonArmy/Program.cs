using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, Dictionary<string, long[]>>();
            var info = new string[] { "damage: ", "health: ", "armor: " };
            for (int i = 0; i < a; i++)
            {

                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = input[0];
                string name = input[1];
                if (input[2] == "null")
                {
                    input[2] = "45";
                }
                else if (input[3] == "null")
                {
                    input[3] = "250";
                }
                else if (input[4] == "null")
                {
                    input[4] = "10";
                }
                long damage = long.Parse(input[2]);
                long health = long.Parse(input[3]);
                long armor = long.Parse(input[4]);
                if (!data.ContainsKey(type))
                {
                    data.Add(type, new Dictionary<string, long[]>());
                }
                if (!data[type].ContainsKey(name))
                {
                    data[type].Add(name, new long[3]);
                }
                data[type][name][0] = damage;
                data[type][name][1] = health;
                data[type][name][2] = armor;
            }
            var add = new List<string>();
            foreach (var item in data)
            {
                string b = "";
                int counter = 0;
                double damage = 0.00;
                double health = 0.00;
                double armor = 0.00;
                foreach (var dragon in item.Value)
                {
                    damage += dragon.Value[0];
                    health += dragon.Value[1];
                    armor += dragon.Value[2];
                    counter++;
                }
                damage = damage / counter;
                damage = Math.Round(damage, 2);
                health = health / counter;
                armor = armor / counter;
                b = "::(" + String.Format("{0:0.00}", damage) + "/" + String.Format("{0:0.00}", health) + "/" + String.Format("{0:0.00}", armor) + ")";
                add.Add(b);
            }
            int counting = 0;
            foreach (var item in data)
            {
                Console.WriteLine(item.Key + add[counting]);
                foreach (var dragons in item.Value.OrderBy(x => x.Key))
                {
                    Console.Write("-" + dragons.Key + " -> ");
                    for (int i = 0; i < dragons.Value.Length; i++)
                    {
                        if (i == dragons.Value.Length - 1)
                        {
                            Console.Write(info[i] + dragons.Value[i]);
                        }
                        else
                        {
                            Console.Write(info[i] + dragons.Value[i] + ", ");
                        }
                    }
                    Console.WriteLine();
                }
                counting++;
            }
        }
    }
}
