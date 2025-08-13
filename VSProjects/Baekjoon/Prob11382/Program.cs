namespace Prob11382
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            long c = long.Parse(input[2]);

            Console.WriteLine(a + b + c);
        }
    }
}
