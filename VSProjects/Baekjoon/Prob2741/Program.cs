using System.Text;

namespace Prob2741
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            int i = 1;
            while (i <= n) {
                sb.AppendLine(i.ToString());
                i++;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
