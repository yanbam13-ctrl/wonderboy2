namespace PPT36_TypeAndActivator
{
    public class Myclass
    {
        public void Test() => Console.WriteLine("MyClass의 Test() 메서드가 실행됩니다.");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("TypeAndActivator.MyClass");
            dynamic objType = Activator.CreateInstance(type);
            objType.Test();
        }
    }
}
