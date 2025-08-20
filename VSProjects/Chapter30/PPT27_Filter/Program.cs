namespace PPT27_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            var maxN = numbers.Max();
            //var nums = numbers.Where(it => it % 2 == 0 && it > 3).Sum();
            //foreach (var num in nums){

            //    Console.WriteLine(num);

            //}

            Console.WriteLine(maxN);
        }
    }
}
