using System;

class PasswordGuess
{
    static void Main()
    {
        string password = "s3cr3t!P@ssw0rd";
        var newpassword = Console.ReadLine();

        if (newpassword == password)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}
