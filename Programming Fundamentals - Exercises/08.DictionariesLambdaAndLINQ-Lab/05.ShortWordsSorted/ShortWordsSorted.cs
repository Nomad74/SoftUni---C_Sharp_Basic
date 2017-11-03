using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] 
            {'.',',',':',';','(',')','[',']','\"','\'','\\','/','!','?',' '};

            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);

            var result = words
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToArray();
                

            Console.WriteLine(string.Join(", ",result));

        }
    }
}

