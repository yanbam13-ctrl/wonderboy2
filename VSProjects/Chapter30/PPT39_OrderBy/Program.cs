namespace PPT39_OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "Red", "Green", "Blue" };
            IEnumerable<string> sortedColors = colors.OrderBy(name => name);

            foreach (var v in sortedColors)
                Console.WriteLine(v);

            sortedColors = colors.OrderByDescending(name => name);
            foreach (var v in sortedColors)
                Console.WriteLine(v);

        }
    }
}
