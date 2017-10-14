using System;

class BonusScore
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        if (number <=100)
        {
            double bonus = 5.0;

            if (number % 2 == 0)
            {
                Console.WriteLine(bonus+1);
                Console.WriteLine(number+bonus+1);
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine(bonus+2);
                Console.WriteLine(number+bonus+2);
            }
            else
            {
                Console.WriteLine(bonus);
                Console.WriteLine(number+bonus);
            }
        }
        else if (number <=1000)
        {
            double bonus = number * 20.0 / 100;

            if (number % 2 == 0)
            {
                Console.WriteLine(bonus + 1);
                Console.WriteLine(number + bonus + 1);
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine(bonus + 2);
                Console.WriteLine(number + bonus + 2);
            }
            else
            {
                Console.WriteLine(bonus);
                Console.WriteLine(number + bonus);
            }
        }
        else
        {
            double bonus = number * 10.0 / 100;

            if (number % 2 == 0)
            {
                Console.WriteLine(bonus + 1);
                Console.WriteLine(number + bonus + 1);
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine(bonus + 2);
                Console.WriteLine(number + bonus + 2);
            }
            else
            {
                Console.WriteLine(bonus);
                Console.WriteLine(number + bonus);
            }
        }
    }
}
