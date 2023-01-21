using System;

/*
 * Задание:
 * 1. Заполнить массив с клавиатуры;
 */

namespace WorkArray
{
    public class WorkArray_1
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
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            //Console.WriteLine(myArray[0]);
            //Console.WriteLine(myArray[1]);
            //Console.WriteLine(myArray[2]);
            //Console.WriteLine(myArray[3]);
            //Console.WriteLine(myArray[4]);
            Console.ReadLine();
        }
    }
}
