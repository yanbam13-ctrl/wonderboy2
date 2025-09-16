namespace PPT36_IteratorDemo
{
    internal class Program
    {
        static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 3;
            yield return 5;
        }
        static void Main(string[] args)
        {
            IEnumerator<int> nums = GetNumbers().GetEnumerator();

            nums.MoveNext();
            Console.WriteLine(nums.Current);

            nums.MoveNext();
            Console.WriteLine(nums.Current);

            nums.MoveNext();
            Console.WriteLine(nums.Current);

            
            Console.WriteLine(nums.MoveNext());
            Console.WriteLine(nums.Current);
            //foreach (var num in nums)
            //{
            //    Console.WriteLine(num + " ");
            //    Console.WriteLine();
            //}
        }
    }
}
