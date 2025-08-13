namespace PPT20_FunctionReturnValue
{
    internal class Program
    {
        static int SquareFunction(int x)
        {
            int r = x * x;
            return r;
        }

        //숫자 n을 입력 받아 홀수면 "홀수" 짝수면 "짝수"를 반환하는 메서드
        static string GetOddEven(int n)
        {

            if (n % 2 == 0)
            {
                return "짝수";
            }
            else return "홀수";
        }



        static void Main(string[] args)
        {
            int r = SquareFunction(2);
            Console.WriteLine(r);

            int n = 13;
            string oddEven = GetOddEven(n);
            Console.WriteLine($"{n}은 {oddEven} 입니다.");
        }
    }
}
