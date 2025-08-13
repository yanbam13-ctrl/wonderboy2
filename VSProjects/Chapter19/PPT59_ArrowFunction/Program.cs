namespace PPT59_ArrowFunction
{
    internal class Program
    {
        static void Hi() => Console.WriteLine("안녕하세요.");

        static int Multiply(int a, int b) => a * b;
        static void Main(string[] args)
        {
            Hi();
            Console.WriteLine(Multiply(3, 5));
        }
    }
}
