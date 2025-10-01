namespace PPT33_IDisposableDemo
{
    public class Toilet : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("[3] 닫기");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] 열기");
            using (var t = new Toilet())
            {
                Console.WriteLine("[2] 사용");
            }
        }
    }
}
