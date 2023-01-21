using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Задание:
 * 2. Вывести массив в обратном порядке;
 */

namespace WorkArray_2
{
    public class WorkArray_2
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];

            Console.WriteLine("Введите значение 1 массива:");
            myArray[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение 2 массива:");
            myArray[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение 3 массива:");
            myArray[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение 4 массива:");
            myArray[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение 5 массива:");
            myArray[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Содержание массива:");
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}
