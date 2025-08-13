namespace Prob1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int cnt = 0;


            while (x > 0)
            {
                if (x % 2 == 1)
                {
                    cnt++;
                }

                x /= 2;
            }

            Console.WriteLine(cnt);

        }
    }
}
