namespace Prob2577_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(input);

            input = Console.ReadLine();
            int b = int.Parse(input);

            input = Console.ReadLine();
            int c = int.Parse(input);

            int[] count = new int[10];
            int multi = a * b * c;

            while (multi > 0)
            {
                int num = multi % 10;
                count[num]++;
                multi /= 10;
            }

            for (int i = 0; i < count.Length; i++) {
                Console.WriteLine(count[i]);
            }
        }
    }
}
