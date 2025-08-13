namespace P084_RealNumberVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 52.273;
            double b = 103.32;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            // float floatVar = float.MaxValue;
            float floatVar = 0.123456789f;
            double doubelVar = double.MaxValue;
            // decimal decimalVar = decimal.MaxValue;
            decimal decimalVar = 1.23456789m;

            Console.WriteLine(floatVar);
            Console.WriteLine(doubelVar);
            Console.WriteLine(decimalVar);
        }
    }
}
