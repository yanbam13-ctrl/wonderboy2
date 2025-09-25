namespace PPT36_SealedClass
{
    class Aniaml
    {
        public void Eat() => Console.WriteLine("밥을 먹습니다.");
    }
    sealed class Cat : Aniaml { }
    //class MyCat : Cat { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
