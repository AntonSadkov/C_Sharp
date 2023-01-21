using System;

/*Задача:
 * Подсчёт, чётных и нечётных чисел в диапозоне, который укажет пользователь.
 */

/*
 * Тернарный оператор
 * [Первый операнд - условие] ? [Второй операнд - if_true] : [Третий операнд - if_false]
 */

namespace CountEvenNumbers
{
    public class CountEvenNumbers
    {
        static void Main(string[] args)
        {
            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine("Введите диапазон подсчёта (Прим. 1 - 100)");
            for (int currentValue = int.Parse(Console.ReadLine()), limit = int.Parse(Console.ReadLine()); currentValue <= limit; currentValue++)
            {
                //if(currentValue % 2 == 0)
                //{
                //    evenCount++;
                //}
                //else
                //{
                //    oddCount++;
                //}
                int variable = currentValue % 2 == 0 ? evenCount++ : oddCount++;
            }
            Console.WriteLine($"Количество чётных чисел: {evenCount}");
            Console.WriteLine($"Количество нечётных чисел: {oddCount}");
            Console.ReadLine();
        }
    }
}
