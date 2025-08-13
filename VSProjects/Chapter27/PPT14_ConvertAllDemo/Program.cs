namespace PPT14_ConvertAllDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = { "10", "20", "30" };

            int[] intArr = Array.ConvertAll(strArr, int.Parse);
            foreach (var number in intArr) {
                Console.WriteLine(number);
            }
        }
    }
}
