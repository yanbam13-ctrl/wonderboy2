using System.Text;

namespace Prob2739_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for(int i = 1; i <= 9; i++)
            {
                sb.AppendLine($"{n} x {i} = {n * i}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
