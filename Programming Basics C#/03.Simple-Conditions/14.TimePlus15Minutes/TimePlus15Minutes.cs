using System;

class TimePlus15Minutes
{
    static void Main()
    {
        var amHour = 0;

        var hour = int.Parse(Console.ReadLine());
        var minute = int.Parse(Console.ReadLine());

        var minutePlus = minute + 15;

        if (minutePlus > 59)
        {
            var newHour = hour + 1;
            var newMinute = minutePlus - 60;

            if (newHour >= 24)
            {
                amHour = newHour - 24;
            }
            else
            {
                amHour = newHour;
            }
                Console.WriteLine($"{amHour}:{newMinute:00}");
        }
        else
        {
             Console.WriteLine($"{hour}:{minutePlus:00}");
        }
    }
}
