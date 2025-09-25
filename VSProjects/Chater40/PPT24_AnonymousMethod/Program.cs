namespace PPT24_AnonymousMethod
{
    public class Print()
    {
        public static void Show(string msg) => Console.WriteLine(msg);
    }
    internal class Program
    {
        //대리자 선언
        public delegate void PrintDelegate(string msg);
        public delegate void SumDelegate(int a, int b);
        static void Main(string[] args)
        {
            //메서드 직접 호출
            Print.Show("안녕하세요.");

            //대리자에 매서드 등록 후 호출
            PrintDelegate pd = new PrintDelegate(Print.Show);
            pd("반갑습니다.");

            PrintDelegate am = delegate (string msg)
            {
                Console.WriteLine(msg);
            };

            am("또 만나요.");

            SumDelegate sd = delegate (int a, int b) { Console.WriteLine(a + b); };
            sd(3, 5);
        }
    }
}
