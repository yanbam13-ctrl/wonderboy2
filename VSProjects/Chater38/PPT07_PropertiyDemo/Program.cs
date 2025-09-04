namespace PPT07_PropertiyDemo
{
    class Developer
    {
        public string Name { get; set; } // 자동 속성
        public bool Adult { get; set; }

        private int age;

        public int Age // 전체속성
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0) return;
                age = value;
            }
        }

        public int MyProperty { get; set; }
        

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();
            developer.Name = "박용준";
            Console.WriteLine(developer.Name);

            developer.Age = -10;
            Console.WriteLine(developer.Age);

            developer.Adult = false;
            Console.WriteLine(developer.Adult);
        }
    }
}
