namespace P110_StringTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberString = "52273";
            int intNumber = int.Parse(numberString);
            Console.WriteLine(intNumber);

            numberString = "52273.13";
            float floatNumber = float.Parse(numberString);
            Console.WriteLine(floatNumber);
        }
    }
}
