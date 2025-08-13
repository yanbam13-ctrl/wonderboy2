namespace PPT09_EnumerationDemo
{
    internal class Program
    {
        enum Priority
        {
            High,
            Normal,
            Low
        }
        static void Main(string[] args)
        {
            Priority high = Priority.High;
            Priority Normal = Priority.Normal;
            Priority Low = Priority.Low;

            Console.WriteLine($"{high}, {Normal}, {Low}");

            Console.WriteLine(((int)Normal));
        }
    }
}
