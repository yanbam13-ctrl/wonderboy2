using System.Numerics;

namespace Prob1271
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //최백준 조교가 가진 돈, 돈을 받으러 온 생명체  m

            //출력 _ 생명체 하나에 돌아가는 돈의 양
            //출력 _ 1원씩 분배할수 없는 돈을 출력한다.

            string[] input = Console.ReadLine().Split();
           
            BigInteger n = BigInteger.Parse(input[0]);
            BigInteger m = BigInteger.Parse(input[1]);

            Console.WriteLine(n / m);
            Console.WriteLine(n % m);
        }
    }
}
