namespace IndexRange 
{
    class IndexRange
    {
        static void Main(string[] args)
        {
            int[] myArray = {1, 23, 32, 4, 52, 61, 34};

            Range myRange = new Range(1,4);//1..4

            int[] myArray2 = myArray[myRange];

            Index myIndex = new Index(3, true); //^3

            Console.WriteLine(myArray[myIndex]);

            string str = "Hello World!!! =)";

            Console.WriteLine(str[^2..]);
        }
    }
}