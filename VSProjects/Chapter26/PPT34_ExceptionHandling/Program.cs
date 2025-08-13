namespace PPT34_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 0;

            try
            {
                a = a / b;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 (에러)가 발생됨:{ex.Message}");
            }
            finally
            {
                Console.WriteLine("try 구문을 정상 종료 합니다.");
            }

            try
            {
                throw new Exception("내가 만든 에러");
            }
            catch (Exception e)
            {
                Console.WriteLine($"예외(에러)가 발생됨 : {e.Message}");
            }
            finally {
                Console.WriteLine("try 구문을 정상 종료합니다.");
            }
        }
    }
}
