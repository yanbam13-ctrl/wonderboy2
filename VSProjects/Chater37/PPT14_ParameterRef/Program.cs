namespace PPT14_ParameterRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Console.WriteLine($"[1] {num}");

            Do(ref num);

            Console.WriteLine($"[3] {num}");

            int num1 = 10;
            int num2 = 20;

            Swap(ref num1, ref num2);
            Console.WriteLine($"num1 : {num1}");
            Console.WriteLine($"num2 : {num2}");
        }

        static void Swap(ref int num1, ref int num2)
        {
            int temp = num2;
            num2 = num1;
            num1 = temp;
        }

        static void Do(ref int num)
        {
            num = 20;
            Console.WriteLine($"[2] {num}");

        }


    }
}
