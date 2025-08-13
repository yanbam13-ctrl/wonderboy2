namespace PPT63_ArrayTwoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            int sum = 0;

            for (int i = 0; i < 2; i++)
            {
                int sumRow = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"arr[{i},{j}] = {arr[i, j]}");
                    sum += arr[i, j];
                    sumRow += arr[i, j];
                }
                Console.WriteLine($"{i}번 행의 합 : {sumRow}");


            }

            Console.WriteLine($"배열의 합 : {sum}");
        }
    }
}
