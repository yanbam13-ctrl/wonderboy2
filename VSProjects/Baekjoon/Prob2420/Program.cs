namespace Prob2420
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);

            long result = n - m;

 

            Console.WriteLine(Math.Abs(result));
        }
    }
}
