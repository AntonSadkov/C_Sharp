using static MethodParams.MethodParams;

namespace MethodParams
{
    public class ParamsClass
    {
        static void Main(string[] args)
        {
            MethodParams.Foo("test", 7, 'q', 7.77f, true);
        }
    }
}
