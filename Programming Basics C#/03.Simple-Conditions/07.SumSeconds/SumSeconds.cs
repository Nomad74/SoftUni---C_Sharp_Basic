using System;

class SumSeconds
{
    static void Main()
    {
        var firstResult = int.Parse(Console.ReadLine());
        var secondResult = int.Parse(Console.ReadLine());
        var thirdResult = int.Parse(Console.ReadLine());

        var time = (firstResult + secondResult + thirdResult);
        
        if (time <=59)
        {
            var minute = 0;
            var result = time;

            if (result < 10)
            {
                Console.WriteLine("{0}:0{1}", minute, result);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minute, result);
            }
        }
        else if (time <=119)
        {
            var minute = 1;
            var result = time-60;

            if (result < 10)
            {
                Console.WriteLine("{0}:0{1}", minute, result);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minute, result);
            }
        }
        else
        {
            var minute = 2;
            var result = time - 120;

            if (result < 10)
            {
                Console.WriteLine("{0}:0{1}",minute,result);
            }
            else
            {
                Console.WriteLine("{0}:{1}",minute,result);
            }
        }
    }
}
