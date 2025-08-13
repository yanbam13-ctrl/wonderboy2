namespace Prob9086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //int i = int.Parse(Console.ReadLine());


            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string str = Console.ReadLine();
                Console.WriteLine($"{str[0]}{str[str.Length-1]}");
            }

        }
    }
}

