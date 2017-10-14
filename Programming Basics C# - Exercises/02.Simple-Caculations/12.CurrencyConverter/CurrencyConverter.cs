using System;

class CurrencyConverter
{
    static void Main()
    {
        float cash = float.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine();
        string outputCurrency = Console.ReadLine();

        if (inputCurrency == "BGN" && outputCurrency == "USD") Console.WriteLine(Math.Round((cash / 1.79549),2)+" USD");
        if (inputCurrency == "BGN" && outputCurrency == "EUR") Console.WriteLine(Math.Round((cash / 1.95583),2)+" EUR");
        if (inputCurrency == "BGN" && outputCurrency == "GBP") Console.WriteLine(Math.Round((cash / 2.53405),2)+" GBP");

        if (inputCurrency == "USD" && outputCurrency == "BGN") Console.WriteLine(Math.Round((cash * 1.79549),2)+" BGN");
        if (inputCurrency == "USD" && outputCurrency == "EUR") Console.WriteLine(Math.Round((cash * 1.79549 / 1.95583),2)+" EUR");
        if (inputCurrency == "USD" && outputCurrency == "GBP") Console.WriteLine(Math.Round((cash * 1.79549 / 2.53405),2)+" GBP");

        if (inputCurrency == "EUR" && outputCurrency == "BGN") Console.WriteLine(Math.Round((cash * 1.95583),2)+" BGN");
        if (inputCurrency == "EUR" && outputCurrency == "USD") Console.WriteLine(Math.Round((cash * 1.95583 / 1.79549),2)+" USD");
        if (inputCurrency == "EUR" && outputCurrency == "GBP") Console.WriteLine(Math.Round((cash * 1.95583 / 2.53405),2)+" GBP");

        if (inputCurrency == "GBP" && outputCurrency == "BGN") Console.WriteLine(Math.Round((cash * 2.53405),2)+" BGN");
        if (inputCurrency == "GBP" && outputCurrency == "USD") Console.WriteLine(Math.Round((cash * 2.53405 / 1.79549),2)+" USD");
        if (inputCurrency == "GBP" && outputCurrency == "EUR") Console.WriteLine(Math.Round((cash * 2.53405 / 1.95583),2)+" EUR");
    }
}
