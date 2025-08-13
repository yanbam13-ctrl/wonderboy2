namespace Prob3733
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str;
            while ((str = Console.ReadLine()) != null) {

                string[] input = str.Split();
                int n = int.Parse(input[0]);
                int s = int.Parse(input[1]);

                Console.WriteLine(s / (1 + n));
            }

            
        }
    }
}
