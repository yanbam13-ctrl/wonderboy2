namespace Prob2438
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string star = "*";

            for (int i = 0; i < count; i++) {
                Console.WriteLine(star);
                star += "*";
            }
        }
    }
}
