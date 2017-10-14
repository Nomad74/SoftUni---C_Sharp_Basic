using System;
class First100
{
    static void Main()
    {
        for (int i = 2; i <= 100; i++)
        {
            if ((i % 2) == 0)
            {
                Console.Write(i + ",");
            }
            else
            {
                Console.Write(-i + ",");
            }
        }
    }
}
