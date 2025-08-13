namespace Prob2475
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++) {
                int n = int.Parse(input[i]);
                sum += n * n;
            }

            Console.WriteLine(sum % 10);

            ////(0 + 16 + 4 + 25 + 36) % 10 = 1
            ////(0 + 4 + 2 + 5 + 6) % 10 = 1

            //string[] input = Console.ReadLine().Split();

            //int a = int.Parse(input[0]);
            //int b = int.Parse(input[1]);
            //int c = int.Parse(input[2]);
            //int d = int.Parse(input[3]);
            //int e = int.Parse(input[4]);
            //int sum = (a * a) + (b * b) + (c * c) + (d * d) + (e * e);

            //Console.WriteLine( sum % 10);
        }
    }
}
