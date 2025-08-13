namespace Prob2501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int cnt = 0;

            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cnt++;
                    if (cnt == k)
                    {
                        result = i;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
