using System;

/*
 * Задача:
Написать программу проверяющую чётность вводиммого числа с консоли.
 */

namespace ParityCheckHW
{
    public class ParityCheck
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Введите число для проверки");
                double number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} число чётное");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{number} число нечётное");
                    Console.ReadLine();
                }
            }
        }
    }
}
