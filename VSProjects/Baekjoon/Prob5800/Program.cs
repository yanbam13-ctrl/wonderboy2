namespace Prob5800
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int tc = int.Parse(input);
            for (int t = 0; t < tc; t++)
            {
                input = Console.ReadLine();
                string[] arrInput = input.Split();
                int n = int.Parse(arrInput[0]);
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(arrInput[i + 1]);

                arrSort(a);
                int gapNum = getLargestGap(a);

                Console.WriteLine($"Class {t + 1}");
                Console.WriteLine($"Max {a[0]}, Min {a[n - 1]}, Largest gap {gapNum}");

            }

        }
        static int getLargestGap(int[] a)
        {
            int maxGapNum = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (maxGapNum < a[i-1] - a[i])
                {
                    maxGapNum = a[i-1] - a[i];
                }
            }
            return maxGapNum;
        }

        static void arrSort(int[] a)
        {
            Array.Sort(a);
            Array.Reverse(a);
        }
    }
}
