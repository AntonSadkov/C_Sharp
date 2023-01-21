namespace Recursion_2
{
    /*
     * Найти сумму элементов массива с помощью рекурсии.
     */

    public class Recursion_2
    {
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;

            return myArray[i] + Sum(myArray, i + 1);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 5, 8, 2, 10 };

            int result = Sum(myArray);
            Console.WriteLine(result);
        }
    }
}
