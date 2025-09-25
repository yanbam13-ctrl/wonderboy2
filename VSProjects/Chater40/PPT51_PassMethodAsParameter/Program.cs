namespace PPT51_PassMethodAsParameter
{
    internal class Program
    {
        static int StringLength(string data) => data.Length;

        static void StringLengthPrint(Func<string, int> stringLength, string message)
            => Console.WriteLine($"메시지의 크기는{stringLength(message)} 입니다.");

        static void Main(string[] args)
        {

            StringLengthPrint(StringLength, "안녕하세요");

        }
    }
}
