using System;

class USDtoBGN
{
    static void Main()
    {
        float usd = float.Parse(Console.ReadLine());
        float bgn = usd * 1.79549f;
        Console.WriteLine(Math.Round(bgn,2)+" BGN");
    }
}
