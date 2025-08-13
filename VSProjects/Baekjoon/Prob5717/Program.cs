namespace Prob5717
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                int m = int.Parse(input[0]);
                int f = int.Parse(input[1]);

                if (m == 0 && f == 0) break;

                Console.WriteLine(m + f);
            }
        }
    }
}
