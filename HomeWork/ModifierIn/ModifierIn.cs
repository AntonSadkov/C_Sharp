using System.Diagnostics;

namespace ModifierIn
{
    public class ModifierIn
    {
        public struct MyStruct
        {
            public int a;
            public int b;   
            public int c;
            public int d;
            public int e;
            public int f;
            public int g;
            public int h;
            public int i;
        }

        static void Main(string[] args)
        {
            MyStruct a = new MyStruct();

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < int.MaxValue; i++) 
            {
                Foo.FooMethod(a);
            }

            sw.Stop();
            Console.WriteLine($"FooMethod {sw.ElapsedMilliseconds}");

            sw.Restart();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Bar.BarMethod(a);
            }

            sw.Stop();
            Console.WriteLine($"BarMethod {sw.ElapsedMilliseconds}");
        }
    }
}