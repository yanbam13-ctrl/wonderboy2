namespace Prob1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double a = int.Parse(input[0]);
            double b = int.Parse(input[1]);

            Console.WriteLine(a / b);
        }
    }
}
