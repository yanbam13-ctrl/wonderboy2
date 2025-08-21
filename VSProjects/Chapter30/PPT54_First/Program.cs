namespace PPT54_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string> { "Red", "Green", "Blue" };
            string? color = colors.First(c => c == "Red");

            Console.WriteLine(color);

            //color = colors.First(c => c == "Black");

            //Console.WriteLine(color);

            color = colors.FirstOrDefault(c => c == "Black");

            Console.WriteLine(color == null? "null" : color);

        }
    }
}
