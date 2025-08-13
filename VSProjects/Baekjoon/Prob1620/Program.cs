using System.Text;

namespace Prob1620
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int n = int.Parse(arrInput[0]);
            int m = int.Parse(arrInput[1]);

            var idToName = new Dictionary<int, string>();
            var nameToId = new Dictionary<string, int>();

            for (int i = 1; i <= n; i++)
            {
                input = Console.ReadLine();

                idToName[i] = input;
                nameToId[input] = i;
               
            }

            var sb = new StringBuilder();

            for (int i = 1; i <= m; i++)
            {
                input = Console.ReadLine();

                if (int.TryParse(input, out int v))
                {
                    sb.AppendLine(idToName[v]);
                }
                else
                {
                    if(input != null)
                    sb.AppendLine(nameToId[input].ToString());
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
