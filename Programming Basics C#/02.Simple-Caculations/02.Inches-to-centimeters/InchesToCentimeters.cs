using System;

class InchesToCentimeters
{
    static void Main()
    {
        Console.Write("Inches = ");
        var inches = double.Parse(Console.ReadLine());
        var centimeters = inches * 2.54;
        Console.WriteLine("centimeters = "+centimeters);
    }
}
