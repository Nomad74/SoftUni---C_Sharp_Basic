using System;

class PersonalTitles
{
    static void Main()
    {
        var age = float.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        if (age < 16)
        {
            if (gender == "m")
            {
                Console.WriteLine("Master");
            }
            else
            {
                Console.WriteLine("Miss");
            }
        }
        else
        {
            if (gender == "m")
            {
                Console.WriteLine("Mr.");
            }
            else
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
