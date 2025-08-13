using System.Text;

namespace PPT30_TimeSpanDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //시간 차(D-Day) 구하기 : TimeSpan 구조체
            TimeSpan dday = Convert.ToDateTime("2025-12-25") - DateTime.Now;

            //Convert.ToDateTime 은 string 값을 DateTime으로 변환 시켜줌
            //DateTime - DateTime = TimeSpan 타입으로 반환

            Console.WriteLine($"{DateTime.Now.Year}년도 크리스마스는 {(int)dday.TotalDays}일 남음");

            //지난 시간 구하기
            TimeSpan times = DateTime.Now - Convert.ToDateTime("1989-04-27");

            Console.WriteLine($"내가 지금까지 며칠 살아왔는지? {(int)times.TotalDays}");
            Console.WriteLine($"내가 지금까지 몇 초를 살아왔는지? {(int)times.TotalSeconds}");

            DateTime start = DateTime.Now;
            string str = "";
            for (int i = 0; i < 50000; i++)
                str += "1234567890";

            DateTime end = DateTime.Now;
            TimeSpan duration = end - start;
            Console.WriteLine("문자열 더하기 : " + duration.TotalMilliseconds);

            start = DateTime.Now;
            StringBuilder strb = new StringBuilder();
            for (int i = 0; i < 50000; i++)
                strb.Append("1234567890");

            end = DateTime.Now;
            duration = end - start;
            Console.WriteLine("문자열 더하기 StringBuilder: " + duration.TotalMilliseconds);

        }
    }
}
