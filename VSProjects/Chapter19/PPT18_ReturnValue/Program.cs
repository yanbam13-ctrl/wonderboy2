namespace PPT18_ReturnValue
{
    internal class Program
    {
        static string GetString()
        {
            return "반환값(Return Value)";
        }
        static void Main(string[] args)
        {
            string returnValue = GetString();

            Console.WriteLine(returnValue);
        }
    }
}
