using System.Numerics;

namespace Prob1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();

                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);

                //mcn = m! / (n! * (m - n)!)

                BigInteger resultM = 1;
                for (int j = m; j > m - n; j--)
                {
                    resultM *= j;
                }

                BigInteger resultN = 1;

                for (int k = 1; k <= n; k++)
                {
                    resultN *= k;
                }

                Console.WriteLine(resultM / resultN);
            }
        }
    }
}
