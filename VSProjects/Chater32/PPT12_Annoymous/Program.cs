namespace PPT12_Anonymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hong = new { Name = "백승수", Age = 21 };
            var park = new { Name = "박문수", Age = 30 };

            Console.WriteLine($"이름 {hong.Name}, 나이 : {hong.Age}");
            Console.WriteLine($"이름 {park.Name}, 나이 : {park.Age}");
        }
    }
}
