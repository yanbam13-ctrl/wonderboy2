namespace Prob10871_
{
    internal class Program
    {

        static void GetNumbers(int[] numbers, int n, int x)
        {
            int[] confirm = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < x)
                {
                    confirm[i] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (confirm[i] == 1)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }


        static void Main(string[] args)
        {
            string[] inputNX = Console.ReadLine().Split();
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(inputNX[0]);
            int x = int.Parse(inputNX[1]);

            int[] numbers = Array.ConvertAll(input, int.Parse);

            GetNumbers(numbers, n, x);




        }
    }
}
