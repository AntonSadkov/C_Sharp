using System;

/*
 * Написать метод для поиска индекса элемента массива (тип в массиве int),
 * метод должен вернуть индекс первого найденного элемента (если он будет найден).
 */
namespace SearchArrayIndex
{
    public class MethodSearchArrayIndex
    {
        /// <summary>
        /// Метод рандомного заполнения массива
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        static public int[] GetRandomArray(uint length)
        {
            int[] myArray = new int[length];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(10);
            }
            return myArray;
        }
        /// <summary>
        /// Метод поиска числа в массиве и вовода его индекса
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        static public int IndexOf(int[] array, int value) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) 
                {
                    Console.WriteLine("\nЧисло найдено, его индекс: ");
                    return i;
                }
            }
            Console.WriteLine("\nЧисло не найдено, вывод отрицательного числа: ");
            return -1;
        }
    }
}
