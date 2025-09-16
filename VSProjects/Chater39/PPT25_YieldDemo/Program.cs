using System.Collections;

namespace PPT25_YieldDemo
{
    internal class Program
    {
        static IEnumerable GetNumbers()
        {
            yield return 1;
            yield return 2;
            for (int i = 3; i <= 5; i++)
            {
                yield return i;
            }
        }
        static void Main(string[] args)
        {
            int sum = 0;
            foreach (int num in GetNumbers())
            {
                Console.Write($"{num}\t", num);
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
