namespace Prob10818_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split();

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (var v in arr) {
                if (v > max) {
                    max = v;
                }

                if (v < min) {
                    min = v;
                }
            }

            Console.WriteLine($"{min} {max}");
        }
    }
}
