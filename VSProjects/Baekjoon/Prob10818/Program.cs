namespace Prob10818
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            string[] input = Console.ReadLine().Split();
            //20 10 35 30 7

            int min = int.Parse(input[0]);
            int max = int.Parse(input[0]);

            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(input[i]);

                if (min > num) {
                    min = num;
                }
               
                if (max < num) {
                    max = num;
                }

            }

            Console.WriteLine($"{min} {max}");
        }
    }
}
