namespace PPT16_IsAn
{
    class Vehicle { }
    class Car : Vehicle { }
    class Airplane : Vehicle { }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Vehicle car = new Car();
            Vehicle airplane = new Airplane();

            Console.WriteLine($"{vehicle},{car},{airplane}");
        }
    }
}
