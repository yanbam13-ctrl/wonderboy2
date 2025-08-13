namespace CallBack
{
    internal class Program
    {
        static void CountDown(int n)
        {
            if (n == 0) return;

            Console.WriteLine(n);

            CountDown(n - 1);
        }

        static void CountUp(int n, int max)
        {

            if (max < n) return;

            Console.WriteLine(n);

            CountUp(n + 1, max);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("CountDown!!");

            CountDown(n);

            CountUp(n, 10);
        }
    }
}
