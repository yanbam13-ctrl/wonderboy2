namespace PPT23_ClassAndMember
{
    internal class ClassName
    {
        public static void MemberName() {
            Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
        }
        static void Main(string[] args)
        {
            ClassName.MemberName();
        }
    }
}
