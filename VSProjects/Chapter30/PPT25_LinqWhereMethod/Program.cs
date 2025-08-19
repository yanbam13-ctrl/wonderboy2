namespace PPT25_LinqWhereMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            IEnumerable<int> q = arr.Where(num => num % 2 == 1);

            foreach (var n in q) {
                Console.WriteLine(n);
            }

            Console.WriteLine(q.Max()); 
        }
    }
}
