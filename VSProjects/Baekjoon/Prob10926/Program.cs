namespace Prob10926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(input + "??!");
            Console.WriteLine($"{input}??!");
            Console.WriteLine("{0}??!",input);

            // Console.WriteLine("{0}??!",input)과 string.Format("{0}??!", input)은 쓰는 방법은 같지만
            // Console.WriteLine은 곧 바로 출력 하고
            // string.Format("{0}??!", input)은 string 변수에 문자열을 저장 시킬수 있다.
            string res = string.Format("{0}??!", input);
            Console.WriteLine(res);
        }
    }
}
