namespace PPT13_AnonymousDelegate
{
    internal class Program
    {
        delegate void SayDelegate();
        static void Main(string[] args)
        {
            SayDelegate say = delegate ()
            {
                Console.WriteLine("반갑습니다.");
            };

            say();
        }
    }
}
