namespace P106_Casts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _int = 2147483647;
            long _long = _int;
            Console.WriteLine(_long);

            long longNumber = 123456789012345L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            float floatNumber = longNumber;
            Console.WriteLine(floatNumber);
        }
    }
}
