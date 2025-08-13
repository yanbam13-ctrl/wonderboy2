namespace P176_PyramidB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9 - i; j++) {
                    Console.Write('.');
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();

            }
        }
    }
}
