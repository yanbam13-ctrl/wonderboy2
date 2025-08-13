namespace Prob1026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] x = Console.ReadLine().Split();
            string[] y = Console.ReadLine().Split();

            int[] a = Array.ConvertAll(x, int.Parse);
            int[] b = Array.ConvertAll(y, int.Parse);

            //Array.Sort(a);
            //Array.Sort(b);
            //Array.Reverse(b);

            //int sum = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    sum += a[i] * b[i];
            //}

            //Console.WriteLine(sum);

            SortArr(a, false);
            SortArr(b, true);
            Console.WriteLine(MultiSum(a, b, n)); 
        }

        static void SortArr(int[] arr, bool flag)
        {
            Array.Sort(arr);

            if (flag)
            {
                Array.Reverse(arr);
            }
        }

        static int MultiSum(int[] a, int[] b, int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += a[i] * b[i]; ;
            }

            return sum;
        }
    }
}
