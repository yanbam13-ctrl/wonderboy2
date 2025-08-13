namespace Prob2010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(Console.ReadLine());

                if (i != n - 1) sum--;
            }

            Console.WriteLine(sum);
        }
    }
}
