using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray_1
{
    public class TwoDimensionalArray_1
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2, 3];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine($"Y: {i}" + $" X: {j}");
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
