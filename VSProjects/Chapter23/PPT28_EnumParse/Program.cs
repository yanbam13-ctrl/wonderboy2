namespace PPT28_EnumParse
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string color = Console.ReadLine();

                if (Enum.IsDefined(typeof(ConsoleColor), color))
                {
                    Console.ForegroundColor = //ConsoleColor.Red;
                (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);

                    Console.WriteLine("Hello World");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("표현할수 없는 색상 입니다.");
                }



                if (color == "E") break;
            }
        }
    }
}
