using System;

class AreaOfRectange
{
    static void Main()
    {
        Console.Write("Insert the size of the first side : ");

        var a = decimal.Parse(Console.ReadLine());

        Console.Write("Insert the size of the second side : ");

        var b = decimal.Parse(Console.ReadLine());

        var area = a * b;

        Console.WriteLine("The area of rectangle is : " + area);
    }

}
