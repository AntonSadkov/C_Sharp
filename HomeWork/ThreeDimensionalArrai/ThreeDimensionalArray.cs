using System;

namespace ThreeDimensionalArrai
{
    public class ThreeDimensionalArray
    {
        static void Main(string[] args)
        {
            Random random= new Random();

            int[,,] myArray = new int[4,6,10];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.WriteLine($"Z: {i}" + $" Y: {j}" + $" X: {k}");
                        //myArray[i, j, k] = int.Parse(Console.ReadLine());
                        myArray[i, j, k] = random.Next(100);
                    }
                }
            }
            Console.WriteLine();

            for (int z = 0; z < myArray.GetLength(0); z++)
            {
                Console.WriteLine($"Страница №: {z + 1}");

                for (int y = 0; y < myArray.GetLength(1); y++)
                {
                    for (int x = 0; x < myArray.GetLength(2); x++)
                    {
                        Console.Write(myArray[z, y, x] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
