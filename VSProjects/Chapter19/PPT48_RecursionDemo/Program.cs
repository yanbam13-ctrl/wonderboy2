namespace PPT48_RecursionDemo
{
    internal class Program
    {
        static int Fact(int n)
        {
            if (n > 1)
                return n * Fact(n - 1);
            else return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(4));
        }
    }
}
