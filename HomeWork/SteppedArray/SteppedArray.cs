using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppedArray
{
    public class SteppedArray
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int [4][];
            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[7];
            myArray[3] = new int[10];

            Random rand = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = rand.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
