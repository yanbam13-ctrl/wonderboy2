namespace PPT08_DelegateNote
{
    internal class Program
    {
        delegate void SayPointer();

        static void Hello() => Console.WriteLine("Hello Delegate");
        static void Main(string[] args)
        {
            SayPointer sayPointer = new SayPointer(Hello);

            sayPointer();
            sayPointer.Invoke();
        }
    }
}
