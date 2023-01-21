using System;

namespace HomeWork
{
    public class RubleExchangeRate
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();

                double usd = 74;

                double eur = 78.99;

                Console.WriteLine("Введите количество валюты");
                double currency = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите валюту");

                string currencySelection = Console.ReadLine();
                double result;

                if (currencySelection == "USD")
                {
                    result = currency * usd;
                    Console.WriteLine($"{currency} USD к RUB {result}");
                }
                if (currencySelection == "EUR")
                {
                    result = currency * eur;
                    Console.WriteLine($"{currency} EUR к RUB {result}");
                }
                if (currencySelection != "USD" && currencySelection != "EUR")
                {
                    Console.WriteLine("Ошибка");
                }
                Console.ReadLine();
            }
        }
    }
}
