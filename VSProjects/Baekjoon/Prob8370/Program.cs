namespace Prob8370
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Console.WriteLine((int.Parse(input[0]) * int.Parse(input[1]))+ (int.Parse(input[2]) * int.Parse(input[3])));
        }
    }
}
