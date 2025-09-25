namespace PPT13_OverrideDemo
{
    internal class Program
    {
        class Developer
        {
            public override string ToString()
            {
                return "개발자";
            }
        }

        static void Main(string[] args)
        {
            Developer dev = new Developer();
            Console.WriteLine(dev.ToString());
        }
    }
}
