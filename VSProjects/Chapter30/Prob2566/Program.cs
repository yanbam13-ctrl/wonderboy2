using System.ComponentModel;

namespace Prob2566
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> list = new List<List<int>>();

            for (int i = 0; i < 9; i++)
            {
                List<int> row = Console.ReadLine().Split().Select(int.Parse).ToList();
                list.Add(row);
            }

            int maxVal = list.Max(r => r.Max());

            Console.WriteLine(maxVal);

            int ansRow = 0; int ansCol = 0;

            for (int i = 0; i < 9; i++)
            {
                int j = list[i].IndexOf(maxVal);
                if (j != -1)
                {
                    ansRow = i;
                    ansCol = j;
                    break;
                }
            }

            Console.WriteLine($"{ansRow + 1} {ansCol + 1}");


        }
    }
}
