namespace PPT07_LinqCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            int count = numbers.Count();

            Console.WriteLine($"{nameof(numbers)} 배열 개수 : {count}");
        }
    }
}
