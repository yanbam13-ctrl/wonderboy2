namespace Prob2438_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i + 1; j--) Console.Write(" ");
                for (int j = 0; j <= i * 2; j++) Console.Write("*");
                // i = 0 일때 -> (0 <= 0)true -> *
                // i = 1 일때 -> (0 <= 1)true -> ** + *
                // i = 2 일때 -> (0 <= 2)true -> *** + ***
                // i = 3 일때 -> (0 <= 3)true -> **** + ****

                Console.WriteLine();

                if (i == n - 1)
                {
                    for (int k = 0; k < n; k++)
                    {
                        for (int j = 0; j <= k; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = (n - 1) * 2 - 1; j > k * 2; j--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }

                }
            }

            //for (int k = 0; k < n; k++)
            //{
            //    for (int j = 0; j < k; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = n * 2 - 1; j > k * 2; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}





/*
 
for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = n * 2 - 1; j > i * 2; j--)
                {
                    Console.Write("*");
                    //Console.Write($"({i},{j})");
                }


                // i = 0 일때, 5 > 0 -> ***** + ***** j가 = 5일때, j = 10 ( 5 * 2 ) 
                // i = 1 일때, 5 > 1 -> **** + **** j가 = 4일때, j = 7 ( 4 * 2 ) -1
                // i = 2 일때, 5 > 2 -> *** + *** j가 = 3일때, j = 5 (3 * 2 ) - 1
                // i = 3 일때, 5 > 3 -> ** + ** j가 = 2일때, j = 3 ( 2 * 1 ) + 1
                // i = 4 일때, 5 > 4 -> * + * j가 = 1일때, j = 1 ( 1 * 1 )

                // 10 > 0 * 2 => 10번
                // 10 > 1 * 2 => 8번
                // 10 > 2 * 2 => 6번 
                // 10 > 3 * 2 => 4번
                // 10 > 4 * 2 => 2번





                Console.WriteLine();

 */