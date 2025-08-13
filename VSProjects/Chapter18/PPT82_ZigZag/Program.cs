namespace PPT82_ZigZag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] zagArray = new int[2][];

            zagArray[0] = new int[] { 1, 2 };
            zagArray[1] = new int[] { 3, 4, 5 };

            for (int i = 0; i < zagArray.Length; i++)
            {
                for (int j = 0; j < zagArray[i].Length; j++)
                {
                    Console.Write($"{zagArray[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
