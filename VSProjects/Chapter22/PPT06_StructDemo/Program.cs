namespace PPT06_StructDemo
{
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            Point point;
            point.x = 100;
            point.y = 200;

            Console.WriteLine($"x : {point.x}, y : {point.y}");
        }
    }
}
