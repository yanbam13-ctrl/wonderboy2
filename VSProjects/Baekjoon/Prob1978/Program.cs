namespace Prob1978
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            string[] arrInput = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arrInput[i]);
            }

            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                if (IsPrime(a[i])) cnt++;
            }

            Console.WriteLine(cnt);


        }
        static bool IsPrime(int n)
        {

            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
