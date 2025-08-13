namespace PPT17_EnumIndex
{
    internal class Program
    {
        enum Aniaml
        {
            Rabbit, Dragon, Snake
        }
        static void Main(string[] args)
        {
            Aniaml aniaml = Aniaml.Dragon;
            int num = (int)aniaml;
            string str = aniaml.ToString();
            Console.WriteLine($"Animal.Dragon : {num}, {str}");
        }
    }
}
