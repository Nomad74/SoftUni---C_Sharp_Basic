using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.AnonymousVox
{
    class AnonymousVox
    {
        static void Main(string[] args)
        {
            var placeholderRegex = new Regex(@"([A-Za-z]+).+\1");

            var valueRegex = new Regex(@"{(.+?)}");

            string text = Console.ReadLine();

            string valuesText = Console.ReadLine();

            var placeholders = placeholderRegex.Matches(text);

            var values = valueRegex.Matches(valuesText);

            for (int i = 0; i < Math.Min(values.Count, placeholders.Count); i++)

            {
                string value = values[i].Groups[1].Value;

                var placeholder = placeholders[i];

                string replacement = $"{placeholder.Groups[1].Value}{value}{placeholder.Groups[1].Value}";

                int startIndex = text.IndexOf(placeholder.Value);

                text = text.Substring(0, startIndex) + replacement

                       + text.Substring(startIndex + placeholder.Length);
            }
            Console.WriteLine(text);
        }
    }
}
