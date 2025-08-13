using System.Text;

namespace Prob7785
{
    internal class Program
    {
        static void Solve(Dictionary<string, string> data)
        {

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input;

            var hs = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] arrInput = input.Split();
                string name = arrInput[0];
                string enterLeave = arrInput[1];

                if (enterLeave == "enter")
                {
                    if (!hs.Contains(name))
                        hs.Add(name);
                }
                else
                {
                    hs.Remove(name);
                }
            }

            StringBuilder sb = new StringBuilder();

            List<string> list = hs.ToList();

            

            list.Sort(StringComparer.Ordinal);

            for (int i = list.Count - 1; i >= 0; i--) // 역순 출력
            {
                sb.AppendLine(list[i]);
            }
            Console.WriteLine(sb);


        }
    }
}
