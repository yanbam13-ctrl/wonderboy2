namespace Prob4101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string? line = Console.ReadLine();
                if (line == null) break; 

                string[] numbers = line.Split();

                int a = int.Parse(numbers[0]);
                int b = int.Parse(numbers[1]);

                if (a == 0 && b == 0)
                {
                    break;
                }
                else if (a < b)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }

            }
        }
    }
}
