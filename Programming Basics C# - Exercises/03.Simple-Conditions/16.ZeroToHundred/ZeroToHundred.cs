using System;

    class ZeroToHundred
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string[] a = new string[] {"zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            string[] b = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] c = new string[] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] d = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        if (n <= 10 && n >= 0)
        {
            string outun = a[n];
            Console.WriteLine(outun);
        }
        else if (n > 20 && n < 100)
        {
            int units = n % 10;
            int digits = n / 10;
            string outputd = c[digits];
            string outputun = d[units];

            if (n % 10 == 0)
            {
                Console.WriteLine("{0}", outputd);
            }
            else
            {
                Console.WriteLine("{0} {1}", outputd, outputun);
            }
        }
        else if (n > 10 && n < 20)
        {
            int units1 = n % 10;
            string oout = b[units1];
            Console.WriteLine(oout);
        }
        else if (n % 10 == 0 && n < 100)
        {
            int desetici = (n / 10);
            string desetki = c[desetici];
            Console.WriteLine(desetki);
        }
        else if (n == 100)
        {
            Console.WriteLine("one hundred");
        }
        else
        {
            Console.WriteLine("invalid number");
        }
    }

}