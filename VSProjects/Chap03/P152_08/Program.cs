namespace P152_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                if (input > 12) {
                    Console.WriteLine("1 ~ 12 사이의 숫자를 입력해주세요.");
                    continue;
                }

                if (input > 11 || input < 3) // 11월 ~ 2월
                {
                    Console.WriteLine("겨울 입니다.");
                }
                else if (input > 2 && input < 6)
                { //3월~5월
                    Console.WriteLine("봄 입니다.");
                }
                else if (input > 5 && input < 10) // 6월~9월
                {
                    Console.WriteLine("여름 입니다.");
                }
                else {
                    Console.WriteLine("가을 입니다.");
                }
            }

        }
    }
}
