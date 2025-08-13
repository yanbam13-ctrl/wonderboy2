namespace Prob10039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 -> 40
            // 65
            // 100
            // 30 -> 40
            // 95

            // 68

            int sum = 0;

            for (int i = 0; i < 5; i++) {
                int num = int.Parse(Console.ReadLine());

                if (num < 40) {
                    num = 40;
                }
                sum += num;                
            }

            Console.WriteLine(sum / 5);

        }
    }
}
