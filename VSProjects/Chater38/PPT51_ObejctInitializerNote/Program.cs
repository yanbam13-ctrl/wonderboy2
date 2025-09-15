namespace PPT51_ObejctInitializerNote
{
    internal class Program
    {
        public class Person
        {
            private string _Name;
            public string Name {
                get { return _Name; }
                set { _Name = value; }
            }

            public int Age { get; set; }
            public string Type { get; set; } = "사람";

        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "백승수";
            p1.Age = 21;
            Console.WriteLine($"{p1.Name}, 나이 {p1.Age}, 타입 : {p1.Type}" );

            Person p2 = new Person() { Name = "이세영", Age = 99 };
            Console.WriteLine($"이름 : {p2.Name}, 나이 : {p2.Age}, 타입 : {p2.Type}");
        }
    }
}
