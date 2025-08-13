namespace PPT20_EnumIndexChange
{
    internal class Program
    {
        enum Animal { 
            Horse,
            Sheep = 5,
            Monkey
        }
        static void Main(string[] args)
        {
            Console.WriteLine((int)Animal.Monkey);

            
        }
    }
}
