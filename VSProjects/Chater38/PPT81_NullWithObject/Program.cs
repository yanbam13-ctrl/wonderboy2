namespace PPT81_NullWithObject
{
    internal class Program
    {
        class Address
        {
            public string Street { get; set; } = "알 수 없음";
        }
        class Person
        {
            public string Name { get; set; }
            public Address Address { get; set; }
        }
        static void Main(string[] args)
        {
            var people = new Person[] { new Person { Name = "RedPlus" }, null };

            ProcessPeople(people);
        }
        static void ProcessPeople(IEnumerable<Person> peopleArray)
        {
            foreach (var person in peopleArray)
            {
                Console.WriteLine($"{person?.Name ?? "아무개"}은(는) " +
                     $"{person?.Address?.Street ?? "아무곳"}에 삽니다.");                
            }

            var otherPeople = null as Person[];

            Console.WriteLine($"첫 번째 사람 : {otherPeople?[0]?.Name ?? "없음"}");

        }
    }
}
