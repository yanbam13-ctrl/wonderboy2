using System.Runtime.Intrinsics.X86;

namespace PPT74_ArrayThree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,,] intArray = new int[2, 3, 4];
            int cnt = 1;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        intArray[i, j, k] = cnt;
                        cnt++;

                        //Console.WriteLine($"({i}, {j}, {k})");
                        Console.Write("{0,2} ", intArray[i, j, k]);

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }




            //int[,,] intArray = new int[2, 3, 4]
            //    {
            //    { {1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12} },
            //    { {13, 14, 15, 16}, {17, 18, 19, 20}, {21, 22, 23, 24} },
            //    };

            //            for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 4; k++)
            //        {
            //             Console.WriteLine($"({i}, {j}, {k})");
            //             //Console.Write("{0,2} ", intArray[i, j, k]);
            //         }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}





        }
    }
}
