namespace PPT70_PropertyValidation
{
    internal class Program
    {
        class Car
        {
            public string Name { get; private set; }
            public Car(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    //빈 값없으면 강제로 ArgumentException 예외 발생
                    throw new ArgumentException();
                }
                this.Name = name;
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car("자동차");
            Console.WriteLine(car.Name);

            Console.WriteLine((new Car("")).Name);
        }
    }
}
