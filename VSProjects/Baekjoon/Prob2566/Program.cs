namespace Prob2566
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[9, 9];
            int max = int.MinValue;
            int[] arrAdress = new int[2];

            for (int i = 0; i < 9; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = int.Parse(input[j]);
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (max < arr[i, j])
                    {

                        max = arr[i, j];
                        arrAdress[0] = i + 1;
                        arrAdress[1] = j + 1;
                    }
                }
            }

            Console.WriteLine(max);
            Console.WriteLine($"{arrAdress[0]} {arrAdress[1]}");



        }
    }
}
