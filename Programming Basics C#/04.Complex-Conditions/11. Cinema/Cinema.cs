using System;

class Cinema
{
    static void Main()
    {
        string projection = Console.ReadLine().ToLower();
        int row = int.Parse(Console.ReadLine());
        int column = int.Parse(Console.ReadLine());

        double price = -1.00;

        if (projection == "premiere") price = 12.00;
        else if (projection == "normal") price = 7.50;
        else if (projection == "discount") price = 5.00;

        Console.WriteLine("{0:f2} leva",price*row*column);
    }
}
