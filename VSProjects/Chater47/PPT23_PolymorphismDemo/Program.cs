namespace PPT23_PolymorphismDemo
{
    //1.Animal 클래스 : 추상 클래스 및 기본 클래스
    public abstract class Animal
    {  //동물들은 '울다'라는 기능이 있어야 한다고 명시
        public abstract string Cry();
    }

    //2.Dog 클래스
    public class Dog : Animal
    {
        public override string Cry() => "멍멍멍";
    }

    //3.Cat 클래스
    public class Cat : Animal
    {
        public override string Cry() => "야옹";
    }

    //4.Trainer 클래스
    public class Trainer
    {
        public void DoCry(Animal animal)
        {
            Console.WriteLine("{0}", animal.Cry());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Dog()).Cry());
            Console.WriteLine((new Cat()).Cry());

            Animal dog = new Dog();
            Console.WriteLine(dog.Cry());
            Animal cat = new Cat();
            Console.WriteLine(cat.Cry());

            Trainer trainer = new Trainer();
            trainer.DoCry(new Dog());
            trainer.DoCry(new Cat());
        }
    }
}
