namespace PPT17_ParameterOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Do(out num);
            Console.WriteLine($"[2] {num}");
        }

        static void Do(out int num)
        {
            num = 1234;
            Console.WriteLine($"[1] {num}");
        }
    }
}
