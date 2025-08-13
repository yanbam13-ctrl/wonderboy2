namespace Prob1932
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            int[,] dp = new int[n, n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j <= i; j++)
                {
                    arr[i, j] = int.Parse(input[j]);
                    dp[i, j] = int.Parse(input[j]);
                }
            }

            for (int i = n - 2; i >= 0; i--) //ex ) n이 5일때, i = 3 부터 시작, 3 > 0 // 3, 2 , 1 , 0 까지 true
            {
                for (int j = 0; j <= i; j++) //[3][0~4] -> dp[i,j] = dp[i,j] + Math.max(dp[i+1,j], dp[i+1,j+1]) 
                {
                    dp[i, j] = dp[i, j] + Math.Max(dp[i + 1, j], dp[i + 1, j + 1]);
                    //n이 5일때
                    //dp[3,0] = dp[3,0] + Math.Max(dp[4,0] + dp[4,1]) -> 2+5 =7
                }
            }

            Console.WriteLine(dp[0,0]);
        }
    }
}
