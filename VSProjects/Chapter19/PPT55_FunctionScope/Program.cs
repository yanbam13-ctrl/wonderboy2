namespace PPT55_FunctionScope
{
    internal class Program
    {
        static string message = "전역 변수";

        static void ShowMessage() {
            string message = "지역 변수";
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            ShowMessage();
            Console.WriteLine(message);
        }
    }
}
