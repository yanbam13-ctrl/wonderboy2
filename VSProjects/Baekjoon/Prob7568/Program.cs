namespace Prob7568
{
    internal class Program
    {
        static int n;
        static People[] pp;
        struct People
        {
            public int weight;
            public int height;
        }

        static int[] Solve(People[] pp, int n)
        {
            int[] getCount = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) continue;
                    if (pp[i].weight < pp[j].weight && pp[i].height < pp[j].height) getCount[i]++;
                }
            }
            return getCount;
        }

        static void OutPut(int[] getCount)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{getCount[i] + 1} ");
            }

        }

        static void Input()
        {
            n = int.Parse(Console.ReadLine());
            pp = new People[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                pp[i].weight = int.Parse(input[0]);
                pp[i].height = int.Parse(input[1]);
            }

        }
        static void Main(string[] args)
        {
            Input();
            int[] getCount = Solve(pp, n);
            OutPut(getCount);
        }
    }
}
