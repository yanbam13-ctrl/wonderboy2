namespace PPT07_Indexer_Demo_Developer
{
    internal class Program
    {
        class Developer
        {
            private string name;
            public string this[int index]
            {
                get { return name; }
                set { name = value; }
            }
        }
        static void Main(string[] args)
        {
            Developer developer = new Developer();
            developer[0] = "백승수";
            Console.WriteLine(developer[0]);

            developer[1] = "이세영";
            Console.WriteLine(developer[1]);

            Console.WriteLine(developer[0]);
            Console.WriteLine(developer[1]);
            Console.WriteLine(developer[2]);
        }
    }
}
