using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Задание:
 * 3. Найти сумму чётных чисел в массиве;
 */

namespace WorkArray_3
{
    public class WorkArray_3
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

            int evenNumberSum = 0;
            int oddNumberSum = 0;

            Console.WriteLine("Содержание массива:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
                //if (myArray[i] % 2 == 0)
                //{
                //    evenNumberSum += myArray[i];
                //}
                //else 
                //{
                //    oddNumberSum += myArray[i];
                //}
            }
            Console.WriteLine($"\nСумма чётных чисел в массиве: {myArray.Where(i => i % 2 == 0).Sum()}");
            Console.WriteLine($"\nСумма нечётных чисел в массиве: {myArray.Where(i => i % 2 != 0).Sum()}");
            Console.ReadLine();
        }
    }
}
