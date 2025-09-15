namespace PPT48_Objectinitialize
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }


            public Person() { }
            public Person(string name, int age)
            {
                Name = name; Age = age;
            }

            static void Main(string[] args)
            {
                Person pp = new Person();
                pp.Name = "이세영";
                pp.Age = 100;

                Person pc = new Person("백승수,", 21);

                Person pi = new Person { Name = "권경민", Age = 30 };

                Console.WriteLine($"{pi.Name}, {pi.Age}");
            }


        }
    }
}
