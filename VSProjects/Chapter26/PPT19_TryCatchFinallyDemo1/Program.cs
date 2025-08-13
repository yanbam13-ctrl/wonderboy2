namespace PPT19_TryCatchFinallyDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 0;
            //int y = 3;
            int r;

            try
            {
                r = x / y;
                Console.WriteLine($"{x} / {y} = {r}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("프로그램을 종료 합니다.");
            }
        }


    }
}
