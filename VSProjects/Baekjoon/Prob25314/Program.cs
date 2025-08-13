namespace Prob25314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string output = "";

            for (int i = 0; i < (num / 4); i++) {
                output += "long ";
            }

            output += "int";
            Console.WriteLine(output);


        }
    }
}
