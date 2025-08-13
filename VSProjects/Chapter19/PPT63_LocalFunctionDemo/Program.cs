namespace PPT63_LocalFunctionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }


            void Display(string text)
            {
                Console.WriteLine(text);
            }
            Display("로컬 함수");


            new Random().Next();
        }
    }
}
