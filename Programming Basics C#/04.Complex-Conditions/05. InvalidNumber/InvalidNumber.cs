using System;

class InvalidNumber
{
    static void Main(string[] args)
    {
        int i = int.Parse(Console.ReadLine());

        if ((i<100 || i>200) && (i!=0))
        {
            Console.WriteLine("invalid");
        }
    }
}