namespace MethodParams
{
    public class MethodParams
    {
        static public void Foo(params object[] parameters)
        {
            string message = "Тип данных {0}, значение {1}";

            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
    }
}
