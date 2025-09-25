using System.Threading.Channels;

namespace PPT07_PartialClass
{
    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Person
    {
        public void Print() => Console.WriteLine($"{Name} : {Age}");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "C#";
            person.Age = 20;

            person.Print();
        }
    }
}
