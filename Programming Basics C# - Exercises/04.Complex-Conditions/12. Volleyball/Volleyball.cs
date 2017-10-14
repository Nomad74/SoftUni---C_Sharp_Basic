using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsInTown = int.Parse(Console.ReadLine());
        double result = 0;

        double gamesInSofia = (48 - weekendsInTown) * 3.00 / 4.00;
        int gamesInTown = weekendsInTown;
        double gamesInHolidays = holidays * 2.00 / 3.00;

        double games = gamesInHolidays + gamesInSofia + gamesInTown;


        if (year == "leap") result = games + (games * 15.00 / 100.00);
        else if (year == "normal") result = games;

        Console.WriteLine(Math.Truncate(result));
    }
}
