namespace Prob5596
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] minScore = Console.ReadLine().Split();
            string[] manScore = Console.ReadLine().Split();
            int minTotal = 0;
            int manTotal = 0;

            for (int i = 0; i < minScore.Length; i++) {
                minTotal += int.Parse(minScore[i]);    
            }

            for (int i = 0; i < manScore.Length; i++)
            {
                manTotal += int.Parse(manScore[i]);
            }

            if (minTotal > manTotal)
            {
                Console.WriteLine(minTotal);
            }
            else {
                Console.WriteLine(manTotal);
            }

        }
    }
}
