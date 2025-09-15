namespace PPTPropertyAll
{
    internal class Program
    {
        class Person
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Name { get; set; } = "백승수";
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine($"{p.Id}, {p.Name}");
        }
    }
}
