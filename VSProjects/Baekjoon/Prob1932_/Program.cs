namespace Prob1932_
{
    internal class Program
    {
        static int[,] arr;
        static int Dfs(int i, int j)
        {
            //arr[i][j] + Math.Max(Dfs(i + 1, j), Dfs(i + 1, j + 1));

            return 0;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    string[] input = Console.ReadLine().Split();
                    arr[i, j] = int.Parse(input[j]);
                }
            }




        }
    }
}
