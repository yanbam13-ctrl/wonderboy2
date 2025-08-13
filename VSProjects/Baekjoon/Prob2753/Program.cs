namespace Prob2753
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
           윤년이면 1, 아니면 0 출력조건: 4의 배수이면서 100의 배수가 아니거나, 400의 배수일 경우
         */

            /*
             윤년의 규칙: 4로 나누어 떨어지는 해: 윤년 (예: 2024년, 2028년) 100으로 나누어 떨어지는 해: 평년 (예: 1900년, 2100년) 
                         400으로 나누어 떨어지는 해: 윤년 (예: 2000년, 2400년) 
             */
            string input = Console.ReadLine();
            int num = int.Parse(input);

            if ((num % 4 == 0 && num % 100 != 0) || (num % 400 == 0) )
            {
                Console.WriteLine(1);
            }
            else {
                Console.WriteLine(0);
            }
        }
    }
}
