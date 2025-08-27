using Korea.Seoul;
using In = Korea.Incheon;

namespace Korea
{
    namespace Seoul
    {
        public class Car
        {
            public void Run() => Console.WriteLine("서울 자동차가 달립니다.");
        }
    }

    namespace Incheon
    {
        public class Car
        {
            public void Run() => Console.WriteLine("인천 자동차가 달립니다.");
        }
    }
}


namespace PPT14_NamespaceDescription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car s = new Car();
            s.Run();

           In.Car i = new In.Car();
            i.Run();
        }
    }
}
