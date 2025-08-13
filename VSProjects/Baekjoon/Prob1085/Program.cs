namespace Prob1085
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[input.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int min = int.MaxValue;

            if (min > arr[0]) min = arr[0];
            if (min > arr[1]) min = arr[1];
            if (min > arr[2] - arr[0]) min = arr[2] - arr[0];
            if (min > arr[3] - arr[1]) min = arr[3] - arr[1];

            Console.WriteLine(min);



        }
    }
}
