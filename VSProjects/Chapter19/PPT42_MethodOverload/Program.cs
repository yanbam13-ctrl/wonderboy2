namespace PPT42_MethodOverload
{
    internal class Program
    {
        static void Hi()
        {
            Console.WriteLine("안녕하세요");
        }
        static void Hi(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Hi(string msg, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(msg);
            }
        }


        static void Main(string[] args)
        {
            Hi();
            Hi("어쩌라고");
            Hi("뭐 인마?", 5);

            Sum(); //0
            Sum(5); // 5
            Sum(7, 3); //10
            Sum(5.3, 2.5); //7.8
        }
        static void Sum()
        {
            Console.WriteLine(0);
        }

        static void Sum(int n)
        {
            Console.WriteLine(n);
        }

        static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Sum(double x, double y)
        {
            Console.WriteLine(x + y);
        }

    }
}
