namespace PPT11_LinqMaxMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<double>() { 3.3, 2.2, 1.1 };

            var max = numbers.Max();
            var min = numbers.Min();

            Console.WriteLine($"리스트의 최대값 : {max:.00}");
            Console.WriteLine($"리스트의 최소값 : {min:.00}");
        }
    }
}
