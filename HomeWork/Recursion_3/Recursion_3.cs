namespace Recursion_2
{
    /*
     * Найти сумму цифр числа с помощью рекурсии.
     * 
     * 561 = 12
     */

    /// <summary>
    /// В классе представленно решение 3 способами, выбрать метод
    /// в зависимости от реализации
    /// </summary>
    public class Recursion_3
    {
        /// <summary>
        /// Решение с переменными для понимания
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static int Foo(int value)
        {
            if(value < 10)
                return value;

            int digit = value % 10;

            int nextValue = value / 10;

            return digit + Foo(nextValue);
        }
        /// <summary>
        /// Компактное решение через рекурсию
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static int Boo(int value)
        {
            if (value < 10)
                return value;

            return value % 10 + Boo(value / 10);
        }
        /// <summary>
        /// Решение через цикл
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static int Voo(int value)
        {
            int result = 0;
            while (value > 0)
            {
                result += value % 10;
                value /= 10;
            }
            return result;
        }
        /// <summary>
        /// Сумма цифр числа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int myValue = 777;

            int result = Voo(myValue);

            Console.WriteLine(result);
        }
    }
}