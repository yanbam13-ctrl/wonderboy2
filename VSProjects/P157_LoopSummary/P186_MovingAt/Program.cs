namespace P186_MovingAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출 후");

            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(2000);
            Console.WriteLine("세 번째 출력");

            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                {
                    Console.WriteLine(" ___@");
                }
                else if (x % 3 == 1)
                {
                    Console.WriteLine("_^@");
                }
                else {
                    Console.WriteLine("^_@");
                }

                Thread.Sleep(100);
                x++;
            }
        }
    }
}
