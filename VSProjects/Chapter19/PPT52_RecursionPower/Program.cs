namespace PPT52_RecursionPower
{
    internal class Program
    {
        static int MyPower(int num, int cnt)
        {
            if (cnt == 0)
            {
                return 1;
            }
            return num * MyPower(num, --cnt);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyPower(2, 8));
        }
    }
}
