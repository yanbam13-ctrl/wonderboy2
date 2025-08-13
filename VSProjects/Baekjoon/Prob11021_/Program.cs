using System.Text;

namespace Prob11021_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= t ; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                sb.AppendLine($"Case #{i}: {a + b}");
            }

            Console.Write(sb.ToString());
        }
    }
}
