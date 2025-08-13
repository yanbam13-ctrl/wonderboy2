namespace Prob25314_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string mes = "long int";
            string frontMes = "";

            for (int i = 0; i < (n / 4) - 1; i++) {
                frontMes += "long ";
            }

            Console.WriteLine(frontMes + mes);
        }
    }
}
