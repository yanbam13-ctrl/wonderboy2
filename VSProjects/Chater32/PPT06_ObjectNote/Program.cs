namespace PPT06_ObjectNote
{
    public  class Counter
    {
        public void GetTodyVisitCount()
        {
            Console.WriteLine("오늘 1234명이 접속했습니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            counter.GetTodyVisitCount();
        }
    }
}
