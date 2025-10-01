namespace PPT05_InterfaceNote
{
    interface ICar
    {
        void Go();
    }

    class Car : ICar
    {
        public void Go() => Console.WriteLine("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야 한다.");
        
            
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Go();
        }
    }
}
