namespace PPT35_DefaultParameter
{
    internal class Program
    {
        static void Log(string message, byte level = 1)
        {
            Console.WriteLine($"{message},{level}");
        }

        static void Main(string[] args)
        {
            Log("디버그");
            Log("에러", 4);

        }
    }
}
