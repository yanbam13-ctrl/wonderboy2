namespace PPT36_RandomDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(5));
            Console.WriteLine(random.Next(1,10));

        }
    }
}
