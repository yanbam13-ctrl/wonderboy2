namespace P129_IfTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(DateTime.Now.Hour < 12)
                Console.WriteLine("오전 입니다.");

            if (DateTime.Now.Hour >= 12)
                Console.WriteLine("오후 입니다.");


        }
    }
}
