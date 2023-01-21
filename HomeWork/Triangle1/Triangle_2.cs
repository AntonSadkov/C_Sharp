using System;
/*
Задача:
*****
****
***
**
*
 */
namespace Triangle1
{
    public class Triangle_2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугрольника: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
