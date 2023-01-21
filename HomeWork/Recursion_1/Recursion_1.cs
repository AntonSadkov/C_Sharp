namespace Recursion_1
{
    /*
     * Реализовать вывод массива с помощью рекурсии.
     */
    public class Recursion_1
    {
        static void PrintArray(int[] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                PrintArray(myArray, i + 1);
            }
        }

        static void Main(string[] args)
        {
            int[] myArray = { 5, 3, 2 };

            PrintArray(myArray);
        }
    }
}