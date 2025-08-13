namespace PPT37_NamedParameter
{
    internal class Program
    {
        static void Sum(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        static void Main(string[] args)
        {
            Sum(10, 20);
            Sum(first: 10, second: 20);
            Sum(second: 20, first: 10);
        }
    }
}
