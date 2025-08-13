namespace PPT32_OutVariableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime day = DateTime.Parse("2025/12/25"); // day = DateTime
            //String 값이 날짜 변환이 불가능한 경우 ex) 2025/12/32 일때는 에러발생 프로그램 종료
            //안전하지 않음


            if (DateTime.TryParse("2019/12/25", out var xmas))
                //ex)2019/12/32 일때 날짜로 변환할수 없으니 false 반환후 다음 코드로 넘어감
                //안전함
                //날짜 변환에 성공하면 xmas에 저장됨 . out var xmas!

            {
                Console.WriteLine(xmas);
            }
        }
    }
}
