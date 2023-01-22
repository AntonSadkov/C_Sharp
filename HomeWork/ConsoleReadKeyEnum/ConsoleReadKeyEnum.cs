namespace ConsoleReadKeyEnum
{
    public class ConsoleReadKeyEnum
    {
        /// <summary>
        /// Вывод на консоль нажатых клавишь с клавиатуры, с использованием enum
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите кнопку на клавиатуре:");
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;

                Console.WriteLine();

                switch (key)
                {

                    case ConsoleKey.Spacebar:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.Backspace:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.Tab:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D0:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D1:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D8:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D9:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.F:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.G:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.H:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.J:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.K:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.L:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.O:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.T:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.U:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.V:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.Y:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    case ConsoleKey.Z:
                        Console.WriteLine($"Вы ввели {key}");
                        break;
                    default:
                        Console.WriteLine("Неизвестное значение");
                        break;
                }
            }
        }
    }
}
