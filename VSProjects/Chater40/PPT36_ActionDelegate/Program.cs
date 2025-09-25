namespace PPT36_ActionDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printf = Console.WriteLine;
            printf("메서드 대신 호출");
            
        }
    }
}
