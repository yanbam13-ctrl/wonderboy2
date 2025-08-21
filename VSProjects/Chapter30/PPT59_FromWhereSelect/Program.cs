namespace PPT59_FromWhereSelect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            var evenNumbers = from num in arr
                              where num % 2 == 0
                              select num;

            foreach(var numbers in evenNumbers)
                Console.WriteLine($"짝수 : {numbers}");
        }
    }
}
