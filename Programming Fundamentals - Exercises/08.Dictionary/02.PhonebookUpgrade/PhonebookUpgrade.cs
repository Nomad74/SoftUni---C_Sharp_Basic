using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
           var phonebook = new SortedDictionary<string, string>();
           var input = Console.ReadLine().Split(' ').ToArray();
           
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phonebook.Add(input[1], input[2]);
                }
                if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{phonebook.Keys} -> {phonebook.Values}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                if (input[0] == "ListALL")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
