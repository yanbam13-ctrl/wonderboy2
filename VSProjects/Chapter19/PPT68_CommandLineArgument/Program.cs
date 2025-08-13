namespace PPT68_CommandLineArgument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("?");
            foreach (string arg in args) {
                Console.WriteLine(arg);
            }
        }
    }
}
