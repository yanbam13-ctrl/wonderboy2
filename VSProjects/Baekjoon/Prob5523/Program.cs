namespace Prob5523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int resultA = 0;
            int resultB = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                if (a > b)
                {
                    //Console.WriteLine($"a > b : a:{a}, b{b}");
                    resultA++;
                }
                else if(a < b) {
                    //Console.WriteLine($"a < b : a:{a}, b{b}");
                    resultB++;
                }                
            }

            Console.WriteLine($"{resultA} {resultB}");
        }
    }
}
