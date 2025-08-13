namespace P189_SwitchWithWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽 이동");
                        break;
                    case ConsoleKey.X:
                        break;
                }
            }

        }
    }
}
