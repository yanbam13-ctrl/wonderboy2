namespace Prob4999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string hopital = Console.ReadLine();

            if (input.Length >= hopital.Length)
            {
                Console.WriteLine("go");
            }
            else {
                Console.WriteLine("no");
            }
        }
    }
}
