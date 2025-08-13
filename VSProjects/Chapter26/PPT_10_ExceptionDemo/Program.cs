namespace PPT_10_ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[2];
                arr[100] = 1234;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
