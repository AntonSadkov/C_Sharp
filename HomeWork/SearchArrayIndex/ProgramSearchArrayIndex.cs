using System;

/*
 * Написать метод для поиска индекса элемента массива (тип в массиве int),
 * метод должен вернуть индекс первого найденного элемента (если он будет найден).
 */

namespace SearchArrayIndex
{
    public class ProgramSearchArrayIndex : MethodSearchArrayIndex
    {
        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10);

            Console.WriteLine("Введите число для поиска его индекса: ");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine("\nЗаданный массив: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();

            int result = IndexOf(myArray, value);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
