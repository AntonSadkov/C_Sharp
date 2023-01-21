using System;

/*
 * Задача:
 * Написать калькулятор, который умеет +, -, *, /.
 * Написать используя конструкцию switch.
 */
namespace Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double num1;
                double num2;
                double result;

                try 
                {
                    Console.WriteLine("Введите число 1");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число 2");
                    num2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка, вводите число для арифметических действий");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Введите операцию +, -, *, /");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        {
                            result = num1 + num2;
                            Console.WriteLine($"Результат сложения {result}");
                        }
                        break;

                    case "-":
                        {
                            result = num1 - num2;
                            Console.WriteLine($"Результат вычитания {result}");
                        }
                        break;

                    case "*":
                        {
                            result = num1 * num2;
                            Console.WriteLine($"Результат умножения {result}");
                        }
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Результат деления {result}");
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Ошибка, неизвестная операция");
                        }
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
