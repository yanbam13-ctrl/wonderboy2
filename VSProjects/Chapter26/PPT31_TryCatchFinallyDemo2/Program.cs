namespace PPT31_TryCatchFinallyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("[1] 시작");

            try
            {
                Console.WriteLine("[2] 실행");
                throw new Exception();// 무작정 에러 발생
            }
            finally
            {
                Console.WriteLine("[3] 종료");
            }

        }
    }
}
