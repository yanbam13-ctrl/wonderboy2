namespace Prob2739
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dan = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{dan} * {i} = {dan * i}");
            }
        }
    }
}
