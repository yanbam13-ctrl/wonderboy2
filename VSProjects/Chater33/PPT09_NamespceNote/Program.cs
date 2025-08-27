using System.Threading.Channels;

namespace Foo
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("[1] Foo 네임스페이스의 Car 클래스 호출");
        }
    }
}

namespace Bar
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("[2] Bar 네임스페이스의 Car 클래스 호출");
        }
    }

}

namespace PPT09_NamespceNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo.Car fooCar = new Foo.Car();
            fooCar.Go();
            Bar.Car barCar = new Bar.Car();
            barCar.Go();
        }
    }
}
