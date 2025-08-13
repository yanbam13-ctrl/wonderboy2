namespace PPT23_StructParameter
{
    internal class Program
    {
        struct Member
        {
            public string name;
            public int age;
        }
        static void Main(string[] args)
        {
            string name = "백승수";
            int age = 21;
            Print(name, age);

            Member m;
            m.name = "이세영";
            m.age = 100;
            Print(m);

            Method(name, age);
            Print(name, age);

            Method(m);
            Print(m);
        }

        static void Print(string name, int age) => Console.WriteLine($"이름 : {name}, 나이 : {age}");
        static void Print(Member member) => Console.WriteLine($"이름 : {member.name}, 나이 : {member.age}");

        static void Method(string name, int age)
        {
            name = "홍길동";
            age = 10;
        }

        static void Method(Member member)
        {
            member.name = "홍길동";
            member.age = 10;
        }



    }
}
