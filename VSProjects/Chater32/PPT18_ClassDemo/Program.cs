namespace PPT18_ClassDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ClassOne.Hi();
            ClassTwo.Hi();
            ClassTwo ct = new ClassTwo();
            ct.Hello();
        }
    }
}
