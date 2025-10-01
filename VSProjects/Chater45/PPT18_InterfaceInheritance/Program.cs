namespace PPT18_InterfaceInheritance
{
    interface IAnimal
    {
        void Eat();
    }
    interface IDog
    {
        void Yelp();
    }

    class Dog : IAnimal, IDog
    {
        public void Eat() => Console.WriteLine("먹다.");
        public void Yelp() => Console.WriteLine("짖다.");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Yelp();
        }
    }
}
