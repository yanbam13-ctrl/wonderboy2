using System.Numerics;

namespace Prob8437
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //첫째줄에는 소녀들이 소유한 사과의 총갯수 10 
            //둘째 줄에는 클라우디아가 소유한 사과의 개수 2

            // 첫줄에는 클라우디아의 사과 개수 6
            // 둘째줄에는 나탈리아의 사과 개수 4

            BigInteger total = BigInteger.Parse(Console.ReadLine());
            BigInteger gap = BigInteger.Parse(Console.ReadLine());

            BigInteger n = 0;
            BigInteger c = 0;

            n = (total - gap) / 2;
            c = total - n;

            Console.WriteLine(c);
            Console.WriteLine(n);
            
        }
    }
}
