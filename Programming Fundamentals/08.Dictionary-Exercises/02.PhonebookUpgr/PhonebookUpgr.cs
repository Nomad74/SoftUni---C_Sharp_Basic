using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgr
{
    class PhonebookUpgr
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            
            string name = "";  string telNumber = "";  string[] input = new string[3];

            while (input[0] !="END")
            {
                input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] =="A")
                {
                    name = input[1];
                    telNumber = input[2];
                    phonebook[name] = telNumber;
                }
                else if(input[0] == "S")
                {
                    name = input[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {telNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }
        }
    }
}
