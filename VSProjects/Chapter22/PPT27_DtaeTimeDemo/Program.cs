namespace PPT27_DtaeTimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"현재 시간 : {DateTime.Now}");
            Console.WriteLine($"현재 년도 : {DateTime.Now.Year}");
            Console.WriteLine($"현재 월 : {DateTime.Now.Month}");
            Console.WriteLine($"현재 일 : {DateTime.Now.Day}");
            Console.WriteLine($"현재 시 : {DateTime.Now.Hour}");
            Console.WriteLine($"현재 분 : {DateTime.Now.Minute}");
            Console.WriteLine($"현재 초 : {DateTime.Now.Second}");
            Console.WriteLine($"현재 밀리초 : {DateTime.Now.Millisecond}");

            DateTime now = DateTime.Now; // 저장되는 시점의 시간 = now

            Console.WriteLine(now.Date);
            Console.WriteLine(DateTime.Now.Nanosecond); // 계속 변경되는 시간
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.Nanosecond);

            Console.WriteLine(now.DayOfWeek);
        }
    }
}
