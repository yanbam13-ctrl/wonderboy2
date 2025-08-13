namespace PPT43_guidDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unique = Guid.NewGuid().ToString();
            Console.WriteLine($"유일한 값 : {unique}");


            Console.WriteLine($"유일한 값 : {Guid.NewGuid().ToString("D")}");
        }
    }
}
