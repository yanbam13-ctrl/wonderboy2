namespace P075_LogicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));

            Console.WriteLine(DateTime.Now.Hour < 3 || DateTime.Now.Hour > 8); // 현재 시간이 3 보다 작다 or 현재 시간이 8 보다 크다
            //ex) 16 < 3 or 16 > 8
            Console.WriteLine(DateTime.Now.Hour > 3 && DateTime.Now.Hour < 8); // 현재 시간이 3보다 크다 and 현재 시간이 8보다 작다
            //ex) 16 > 3 or 16 < 8

            int a = 10;
            Console.WriteLine(2 < 1 || ++a > 10);
            Console.WriteLine(a);
        }
    }
}
