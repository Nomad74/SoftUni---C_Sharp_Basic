using System;
using System.Globalization;

class АThousandDaysAfterBirth
{
    static void Main()
    {
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
        DateTime afterThousandDays = birthDate.AddDays(999);
        Console.WriteLine(afterThousandDays.ToString("dd-MM-yyyy"));
    }
}
