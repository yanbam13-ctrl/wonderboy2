namespace PPT62_AnonymousType
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var data = new { Id = 1, Name = "익명 형식" };
            Console.WriteLine($"{data.Id} - {data.Name}");
            //data = new { Id = 1.0, Name = "익명 형식" };
        }
    }
}
