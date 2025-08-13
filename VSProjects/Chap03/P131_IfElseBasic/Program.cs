namespace P131_IfElseBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수 입니다.");
            }
            else
            {
                Console.WriteLine("홀수 입니다.");
            }
        }
    }
}
