namespace PPT15_ClassDescription
{
    internal class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("클래스");
        }

        public void InstanceMethod()
        {
            Console.WriteLine("인스턴스 메서드");
        }
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            MyClass.MyMethod();

            my.InstanceMethod();
        }
    }
}
