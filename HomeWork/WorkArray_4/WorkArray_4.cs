using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Задание:
 * 4. Найти наименьшее число в массиве;
 */

namespace WorkArray_4
{
    public class WorkArray_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int elementCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\nВведите элемент массива под индексом {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            //int minValue = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] < minValue)
            //    {
            //        minValue = myArray[i];
            //    }
            //}
            Console.WriteLine($"\nМинимальное значение массива: {myArray.Min()}");
            Console.ReadLine();
        }
    }
}
