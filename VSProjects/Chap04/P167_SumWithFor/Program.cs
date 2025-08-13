namespace P167_SumWithFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ~ 100 수 중 3의 배수의 합

            int output = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    output += i;
                }
            }

            Console.WriteLine(output);
        }
    }
}
