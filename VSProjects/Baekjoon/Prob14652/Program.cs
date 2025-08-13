namespace Prob14652
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N = 3, M = 4, K = 6 -> 1 , 2

            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int k = int.Parse(input[2]);

            int a = k / m;
            int b = k % m;

            Console.WriteLine($"{a} {b}");


        }
    }
}
