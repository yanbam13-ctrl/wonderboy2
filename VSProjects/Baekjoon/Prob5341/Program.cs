namespace Prob5341
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                int sum = 0;

                if (n == 0) break;
                for (int i = n; i > 0; i--)
                {
                    sum += i;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
