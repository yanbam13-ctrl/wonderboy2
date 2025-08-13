namespace Prob11022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {

                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                Console.WriteLine($"Case #{i + 1}: {a} + {b} = {a + b}");
            }
        }
    }
}
