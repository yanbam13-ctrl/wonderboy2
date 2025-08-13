using System.Text;

namespace P138_SwitchBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            int input = int.Parse(Console.ReadLine());

            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수 입니다.");
                    break;
                case 1:
                    Console.WriteLine("홀수 입니다.");
                    break;                

            }
        }
    }
}
