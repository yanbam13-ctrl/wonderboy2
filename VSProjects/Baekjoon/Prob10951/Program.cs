namespace Prob10951
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] splitNum = input.Split();
                int a = int.Parse(splitNum[0]);
                int b = int.Parse(splitNum[1]);

                Console.WriteLine(a + b);
            }

        }
    }
}
