using System;

namespace Калькутор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение 4.Деление");

            double operation = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (operation)
            {
                case 1:
                    result = a + b;
                    break;
                case 2:
                    result = a - b;
                    break;
                case 3:
                    result = a * b;
                    break;
                case 4:
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }

            Console.WriteLine($"Результат операции: {result}");
            Console.ReadKey();
        }

    }
}