namespace P159_ArrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 273, 32, 65, 103 };

            intArray[0] = 0;

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);

            Console.WriteLine(intArray.Length);
        }
    }
}
