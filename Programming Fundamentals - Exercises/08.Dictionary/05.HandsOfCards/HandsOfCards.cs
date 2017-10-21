using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var sumByNames = new Dictionary<string, int>();

            while (text[0] != "JOKER")
            {
                var cards = text[1].Split(new char[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
                int totalsum = 0;

                for (int i = 0; i < cards.Length; i++)
                {
                    var card = cards[i];
                    int sum = LeftSide(card) * RightSide(card);
                    totalsum += sum;
                }
                if (sumByNames.ContainsKey(text[0]))
                {
                    sumByNames[text[0]] += totalsum;
                }
                else
                {
                    sumByNames[text[0]] = totalsum;
                }

                text = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var item in sumByNames)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }

        static int RightSide(string card)
        {
            int sum = 0;
            char a = card[card.Length - 1];
            switch (a)
            {
                case 'S':
                    sum += 4;
                    break;
                case 'H':
                    sum += 3;
                    break;
                case 'D':
                    sum += 2;
                    break;
                case 'C':
                    sum += 1;
                    break;

            }
            return sum;
        }

        static int LeftSide(string card)
        {
            string number = new string(card.Where(char.IsDigit).ToArray());
            if (number == "")
            {
                var a = card.First();
                switch (a)
                {
                    case 'J':
                        number += "11";
                        break;
                    case 'Q':
                        number += "12";
                        break;
                    case 'K':
                        number += "13";
                        break;
                    case 'A':
                        number += "14";
                        break;
                }
            }
            int b = int.Parse(number);
            return b;

        }
    }
}
