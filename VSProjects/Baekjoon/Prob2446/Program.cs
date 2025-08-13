namespace Prob2446
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" "); // i가 0일때 x i가 1일때 1, i가 2일때 2, i가 3일때 3, i가 4일때 4, i가 5일때
                }


                for (int j = 0; j < (n * 2) - ((2 * i) + 1); j++)
                {
                    Console.Write("*");
                    //Console.Write($"({i}, {j})");
                }

                Console.WriteLine();

                if (i == n - 1)
                {
                    for (int k = 0; k < n - 1; k++)
                    {
                        for (int j = n - 2; j > k; j--)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < 3 + (k * 2); j++)
                        {
                            Console.Write("*");

                        }
                        // 0 일때 -> 1 + (1 * 2) =  -> 3
                        // 1 일때 -> 2 + (1 * 2) =   -> 5
                        // 2 일때 -> 3 + (1 * 2) =   -> 7
                        // 3 일때 -> 4 + (1 * 2) =   -> 9

                        Console.WriteLine();
                    }
                }

            }
        }
    }
}
