using System.Text;

namespace Prob10816
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] inputN = Console.ReadLine().Split();
            int[] myCard = inputN.Select(int.Parse).ToArray();

            int m = int.Parse(Console.ReadLine());

            string[] inputM = Console.ReadLine().Split();
            int[] numbers = inputM.Select(int.Parse).ToArray();

            var count = new Dictionary<int, int>();
            foreach (int x in myCard)
            {
                if (count.ContainsKey(x)) count[x]++;
                else count[x] = 1;
            }

            var sb = new StringBuilder();

            foreach (int q in numbers)
            {
                sb.Append(count.TryGetValue(q, out int c) ? c : 0);
                sb.Append(' ');
            }

            Console.WriteLine(sb.ToString().TrimEnd());


        }
    }
}
