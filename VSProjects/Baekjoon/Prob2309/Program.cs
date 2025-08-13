namespace Prob2309
{
    internal class Program
    {
        static int total = 0;

        static int n = 9;
        static int[] a = new int[n];
        static void Input(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                total += a[i];
            }
        }

        static void Solve(int[] a, int n)
        {
            int[] outNum = new int[2];
            for (int i = 0; i < n; i++)
            {
                bool flag = false;
                for (int j = 0; j < n; j++)
                {
                    if (i != j && (total - 100) == a[i] + a[j])
                    {
                        outNum[0] = i;
                        outNum[1] = j;
                        flag = true;
                        break;
                    }
                }
                if (flag) break;
            }

            for (int i = 0; i < 9; i++)
            {
                if (i != outNum[0] && i != outNum[1])
                    Console.WriteLine(a[i]);
            }
        }

        static void Main(string[] args)
        {
            Input(a, n);
            Array.Sort(a);
            Solve(a, n);
        }
    }
}
