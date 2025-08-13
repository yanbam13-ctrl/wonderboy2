namespace Prob25238
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            float result = a - (a * ((float)b / 100));

            if (result >= 100)
            {
                Console.WriteLine("0");
            }
            else {
                Console.WriteLine("1");
            }

                
        }
    }
}
