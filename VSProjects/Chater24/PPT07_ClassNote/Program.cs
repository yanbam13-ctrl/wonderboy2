namespace PPT07_ClassNote
{
    internal class ClassNote
    {
        static void Run()
        {
            Console.WriteLine("ClassNote 클래스의 Run 메서드");
        }
        static void Main(string[] args)
        {
            Run();
            ClassNote.Run(); // 정적(static) 메서드
            "Abc".ToString(); // 인스턴스(instance) 메서드
            
        }
    }
}
