using System;
/*
Задача:
*
**
***
****
*****
 */

namespace Triangle
{
    public class Triangle_1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугрольника: ");
            int height = int.Parse(Console.ReadLine());

            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
