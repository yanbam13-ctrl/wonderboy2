namespace PPT08_InaterfaceExam
{
    interface IPerson
    {
        void Work();
    }

    class Persom : IPerson
    {
        public void Work() => Console.WriteLine("일을 합니다.");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Persom person = new Persom();
            person.Work();
        }


    }
}
