using System;

/*Задание:
1) Написать метод, который выводит на экран строку.
Символы строки, задаёт пользователь.
*/
namespace StringMethod
{
    public class StringMethod
    {
        static public string StringOutput(string result)
        {
            Console.WriteLine("Введите строку для вывода: ");
            result = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Вывод строки: \n{result}");
            return result;
        }
    }
}
