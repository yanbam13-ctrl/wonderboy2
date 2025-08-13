namespace P112_ToStringBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNumber = 52;
            //string strNumber = (string)intNumber
            string strNumber = intNumber.ToString();
            Console.WriteLine(strNumber);

            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("00.0000"));
            Console.WriteLine(number.ToString("000.0000"));
        }
    }
}
