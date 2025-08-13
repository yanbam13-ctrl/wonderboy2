using System.Text;

namespace Prob15552
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using var reader = new StreamReader(Console.OpenStandardInput());
            using var writer = new StreamWriter(Console.OpenStandardOutput());

            int count = int.Parse(reader.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                string[] input = reader.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                sb.AppendLine((a + b).ToString());
            }

            writer.Write(sb.ToString());

            //int count = int.Parse(Console.ReadLine());

            //for (int i = 0; i < count; i++)
            //{
            //    string[] input = Console.ReadLine().Split();
            //    int a = int.Parse(input[0]);                
            //    int b = int.Parse(input[1]);

            //    Console.WriteLine(a + b);
            //}
        }
    }
}
