namespace Prob3046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (R1 + R2) / 2 = S
            // (R1 : 11 + R2 : x) / 2 = S : 15
            string[] input = Console.ReadLine().Split();

            int R = int.Parse(input[0]);
            int S = int.Parse(input[1]);

            Console.WriteLine(2 * S - R); 

        }
    }
}
