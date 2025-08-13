namespace PPT65_is
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object x = 1234;

            if (x is int) {
                Console.WriteLine($"{x}는 정수형으로 변환이 가능합니다.");
            }
        }
    }
}
