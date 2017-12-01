using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            var messages = new List<string>();
            var broadcasts = new List<string>();

            string messagePattern = @"^((?<recipient>[0-9]+)\s<->\s(?<mess>[a-zA-Z0-9]+))$";
            string broadcastPattern = @"^((?<message>[\D]+)\s<->\s(?<frequency>[a-zA-Z0-9]+))$";

            string input = Console.ReadLine();

            string privateMessages = string.Empty;
            string broadcastMessages = string.Empty;


            string recipient = string.Empty;
            string mess = string.Empty;

            string message = string.Empty;
            string frequency = string.Empty;



            while (input != "Hornet is Green")
            {
                Match mMess = Regex.Match(input, messagePattern);
                Match bMess = Regex.Match(input, broadcastPattern);



                if (mMess.Success)
                {
                    recipient = mMess.Groups["recipient"].Value;
                    mess = mMess.Groups["mess"].Value;
                    privateMessages = $"{ReverseString(recipient)} -> {mess}";
                    messages.Add(privateMessages);
                }

                if (bMess.Success)
                {
                    message = bMess.Groups["message"].Value;
                    frequency = bMess.Groups["frequency"].Value;
                    broadcastMessages = $"{ReverseCaps(frequency)} -> {message}";
                    broadcasts.Add(broadcastMessages);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            foreach (var item in broadcasts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }

            foreach (var element in messages)
            {
                Console.WriteLine(element);
            }
        }
        static string ReverseString(string txt)
        {
            char[] rev = txt.ToCharArray();
            Array.Reverse(rev);
            return new string(rev);
        }

        static string ReverseCaps(string txt)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < txt.Length; i++)
            {
                if (Char.IsLower(txt[i]))
                {

                    sb.Append(Char.ToUpper(txt[i]));
                }
                else if (Char.IsUpper(txt[i]))
                {

                    sb.Append(Char.ToLower(txt[i]));
                }
                else
                {
                    sb.Append(txt[i]);
                }
            }
            return sb.ToString();
        }
    }
}
