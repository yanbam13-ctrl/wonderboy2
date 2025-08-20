namespace PPT35_TakeSkip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Range(0, 100);

            List<int> takeList = data.Take(5).ToList();

            PrintList(takeList);

            takeList = data.Where(n => n % 2 == 0).Take(5).ToList();
            PrintList(takeList);

            List<int> skipList = data.Skip(10).Take(5).ToList();
            PrintList(skipList);
        }

        static void PrintList(List<int> list)
        {
            foreach (var v in list)
                Console.Write(v + " ");
            Console.WriteLine();
        }
    }
}
