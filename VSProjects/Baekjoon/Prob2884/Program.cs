namespace Prob2884
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int hour = int.Parse(input[0]);
            int min = int.Parse(input[1]);

            min -= 45;

            if (min < 0)
            {
                min += 60;
                hour -= 1;
                if (hour < 0)
                {
                    hour = 23;
                }
            }

            Console.WriteLine($"{hour} {min}");

        }
    }
}
