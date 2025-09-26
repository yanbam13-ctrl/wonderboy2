namespace PPT13_SealedMethod
{
    class Parent
    {
        public virtual void Work() => Console.WriteLine("프로그래머");
    }
    class Child : Parent
    {
        public sealed override void Work() => base.Work();
    }

    class GrandChild : Child
    {
        //public override void Work() => Console.WriteLine("프로게이머");

        public void Play() => Console.WriteLine("프로게이머");
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
