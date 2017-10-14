using System;

class Program
{
    static void Main()
    {
        Console.Write("Insert n (2<=n<100) :");

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            string star = new string('*', i);
            string space = new string(' ', n - 1);
            Console.WriteLine(space);
            Console.WriteLine(star);
        }
    }
}
