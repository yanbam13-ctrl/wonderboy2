using System.Numerics;

namespace Prob14928
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            //20000303200003032000030320000303200003032000030320000303200003032000030320000303
            int mod = 20000303;

            long result = 0;
            foreach (char c in n) {
                int digit = c - '0';

                result = (result * 10 + digit) % mod;
            }

            Console.WriteLine(result);



        }
    }
}
