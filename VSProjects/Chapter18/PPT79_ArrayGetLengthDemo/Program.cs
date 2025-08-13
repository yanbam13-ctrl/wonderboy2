namespace PPT79_ArrayGetLengthDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[2, 3, 4]
                {
                { {1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12} },
                { {13, 14, 15, 16}, {17, 18, 19, 20}, {21, 22, 23, 24} },
                };

            Console.WriteLine("차수 출력 : {0}", arr.Rank);
            Console.WriteLine("차수 출력 : {0}", arr.Length);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write("{0}\t", arr[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
