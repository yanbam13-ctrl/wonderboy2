using System.Text;

namespace Prob2742
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = n; i >= 1; i--) { 
            sb.AppendLine(i.ToString());            
            }          

            Console.WriteLine(sb.ToString());
        }
    }
}
