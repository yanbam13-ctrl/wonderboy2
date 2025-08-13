namespace PPT14_EnumAnimal
{
    internal class Program
    {
        enum Aniaml { Mouse, Cow, Tiger }
        static void Main(string[] args)
        {
            Aniaml animal = Aniaml.Tiger;
            Console.WriteLine(animal);

            if(animal == Aniaml.Tiger) Console.WriteLine("호랑이");
            if(animal >= Aniaml.Cow) Console.WriteLine("소 또는 호랑이");

            
        }
    }
}
