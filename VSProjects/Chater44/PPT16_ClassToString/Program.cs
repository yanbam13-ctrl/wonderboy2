namespace PPT16_ClassToString
{
    class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public override string ToString() => $"[Person 클래스 : {this.name}]";                 
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("박용준");
            Console.WriteLine(person);
        }
    }
}
