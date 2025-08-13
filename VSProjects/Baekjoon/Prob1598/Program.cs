namespace Prob1598
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            int rowDiff = Math.Abs(((y - 1) / 4) - ((x - 1) / 4));
            int colDiff = Math.Abs(((y - 1) % 4) - ((x - 1) % 4));

            Console.WriteLine(rowDiff + colDiff);

        }
    }
}
