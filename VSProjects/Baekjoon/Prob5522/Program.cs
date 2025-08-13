namespace Prob5522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 5; i++) {

                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
