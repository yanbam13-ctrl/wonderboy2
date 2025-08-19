namespace Prob2576
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int[] arr = a.Where(x => x % 2 == 1).ToArray();

            if (arr.Count() != 0)
            {
                Console.WriteLine(arr.Sum());
                Console.WriteLine(arr.Min());
            }
            else {
                Console.WriteLine(-1);
            }
        }
    }
}
