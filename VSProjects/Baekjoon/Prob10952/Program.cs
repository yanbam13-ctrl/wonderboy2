namespace Prob10952
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                if (a == 0 && b == 0) break;

                Console.WriteLine(a + b);
            }
        }
    }
}

