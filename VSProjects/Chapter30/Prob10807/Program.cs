namespace Prob10807
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int x = int.Parse(Console.ReadLine());

            var result = arr.Count(num => num == x);

            Console.WriteLine(result);
        }
    }
}
