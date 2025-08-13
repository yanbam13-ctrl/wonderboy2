namespace PPT21_EnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 5);

            int[] numbersArr = Enumerable.Range(1, 5).ToArray();

            foreach(var n in numbers)
                Console.Write("{0}\t",n);
            Console.WriteLine();

            var sameNumbers = Enumerable.Repeat(-1, 5);

            List<int> numbersList = Enumerable.Range(1, 5).ToList();
            foreach(var n in sameNumbers)
                Console.Write("{0}\t",n);
            Console.WriteLine();
        }
    }
}
