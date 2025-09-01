namespace PPT06_ConstructorDemo
{
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("생성자가 호출되었습니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorDemo c = new ConstructorDemo();
        }
    }
}
