namespace Prob16430
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //공통된 약수가 없다.
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]); // 2
            int b = int.Parse(input[1]); // 7

            Console.WriteLine($"{(b - a)} {b}");
        }
    }
}
