namespace PPT21_InterfaceExplicit
{
    interface IDog
    {
        void Eat();
    }
    interface ICat
    {
        void Eat();
    }
    class Pet : IDog, ICat
    {
        void IDog.Eat()
        {
            Console.WriteLine("Dog Eat");
        }

        void ICat.Eat()
        {
            Console.WriteLine("Cat Eat");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            ((IDog)pet).Eat();
            ((ICat)pet).Eat();

            IDog dog = new Pet();
            dog.Eat();
            ICat cat = new Pet();
            cat.Eat();
        }
    }
}
