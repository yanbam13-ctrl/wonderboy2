using System.Numerics;

namespace Prob10757
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            BigInteger a = BigInteger.Parse(input[0]);
            BigInteger b = BigInteger.Parse(input[1]);

            Console.WriteLine(a+b);
        }
    }
}
