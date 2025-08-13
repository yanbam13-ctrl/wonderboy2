namespace Prob2562_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int count = -1;

            for (int i = 0; i < 9; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                    count = i + 1;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(count);
        }
    }
}
