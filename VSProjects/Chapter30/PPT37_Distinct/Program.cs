namespace PPT37_Distinct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Repeat(3, 5);

            var result = data.Distinct().ToList();

            PrintList(result);

            var list = new List<int> { 2, 2, 3, 3, 3 };

            list = list.Distinct().ToList();

            PrintList(list);
        }

        static void PrintList(List<int> list)
        {
            foreach (var v in list)
                Console.Write(v + " ");
            Console.WriteLine();
        }
    }
}
