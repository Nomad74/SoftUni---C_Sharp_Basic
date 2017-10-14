using System;

class EqualWords
{
    static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

       string word1s = word1.ToLower();
       string word2s = word2.ToLower();

        if (word1s == word2s) Console.WriteLine("yes");
        else Console.WriteLine("no");
    }
}
