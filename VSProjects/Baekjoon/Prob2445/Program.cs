namespace Prob2445
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int n = 5;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < (n * 2) - ((i + 1) * 2); j++) // j + i = 0 / 2
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                if (i + 1 == n)
                {
                    for (int k = 0; k < n - 1; k++)
                    {
                        for (int j = n; j > k + 1; j--)
                        {
                            Console.Write("*");
                        }
                        for (int j = 0; j < (k + 1) * 2; j++) // j + i = 0 / 2
                        {
                            Console.Write(" ");
                        }
                        for (int j = n; j > k + 1; j--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                /*        
                 *        *  * 찍고 8칸 띄고 * = 총 10칸  // 2        3 4 5 6 7 8 9 
                 **      **  ** 찍고 6칸 띄고 ** = 총 10칸 // 4       5 6 7 8 9
                 ***    ***  *** 찍고 4칸 띄고 *** = 총 10칸 // 6     7 8 9
                 ****  ****  **** 찍고 2칸 띄고 **** = 총 10칸 // 8   9
                 **********  ********** = 총 10칸            //   10
                 ****  ****  **** 찍고 2칸 띄고 ****
                 ***    ***  *** 찍고 4칸 띄고 ***
                 **      **  ** 찍고 6칸 띄고 **
                 *        *  * 찍고 8칸 띄고 *
                 */
            }
        }
    }
}
