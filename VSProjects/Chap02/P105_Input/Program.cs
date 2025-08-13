using System.Threading.Channels;

namespace P105_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //Console.WriteLine("input :" + input);

            int read = Console.Read();
            Console.WriteLine(read);

            read = Console.Read();
            Console.WriteLine(read);

            //read = Console.Read();
            //Console.WriteLine((char)read);
        }
    }
}
