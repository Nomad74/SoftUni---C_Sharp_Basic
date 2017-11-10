using System;

class TradeComissions
{
    static void Main()
    {
        var town = Console.ReadLine().ToLower();
        var sales = double.Parse(Console.ReadLine());
        double comission = -1;

        if (town == "sofia")
        {
            if ((0 <= sales) && (sales <= 500)) comission = 5.00 / 100;
            else if ((500 < sales) && (sales <= 1000)) comission = 7.00 / 100;
            else if ((1000 < sales) && (sales <= 10000)) comission = 8.00 / 100;
            else if (sales > 10000) comission = 12.00 / 100;
        }
        if (town == "varna")
        {
            if ((0 <= sales) && (sales <= 500)) comission = 4.50 / 100;
            else if ((500 < sales) && (sales <= 1000)) comission = 7.50 / 100;
            else if ((1000 < sales) && (sales <= 10000)) comission = 10.00 / 100;
            else if (sales > 10000) comission = 13.00 / 100;
        }
        if (town == "plovdiv")
        {
            if ((0 <= sales) && (sales <= 500)) comission = 5.50 / 100;
            else if ((500 < sales) && (sales <= 1000)) comission = 8.00 / 100;
            else if ((1000 < sales) && (sales <= 10000)) comission = 12.00 / 100;
            else if (sales > 10000) comission = 14.50 / 100;
        }

        if (comission >= 0)
            Console.WriteLine("{0:f2}", sales * comission);
        else
            Console.WriteLine("error");
    }
}
