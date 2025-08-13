namespace PPT2_GetSumTwoNumber
{
    internal class Program
    {
        static double GetSum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            double result = GetSum(3.0, 0.14);
            Console.WriteLine(result);
        }
    }
}
