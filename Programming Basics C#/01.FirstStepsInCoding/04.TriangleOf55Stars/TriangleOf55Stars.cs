using System;

class TriangleOf55Stars
{
    static void Main()
    {
        string counter = "*";

        for (int i=0; i<10; i++ )
        {
            Console.WriteLine(counter);

            counter = counter + "*";
        }

    }
}
