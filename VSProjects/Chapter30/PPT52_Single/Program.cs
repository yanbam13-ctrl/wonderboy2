namespace PPT52_Single
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string> { "Red", "Green", "Blue" };

            string red = colors.Single(c => c == "Red");
            Console.WriteLine(red);

            //string black = colors.Single(c => c == "Black");
            string? black = colors.SingleOrDefault(c => c == "Black");
            //Console.WriteLine(black); 
            Console.WriteLine(black == null ? "null" : black);


        }
    }
}
