namespace Prob25304_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 첫째 줄에는 영수증에 적힌 총 금액 x
            int x = int.Parse(Console.ReadLine());

            //둘째 줄에는 영수증에 적힌 구매한 물건의 종류의 수 n
            int n = int.Parse(Console.ReadLine());

            //이후 n개의 줄에는 각 물건의 가격 a의 개수 b가 공백을 사이에 두고 주어진다.

            //구매한 물건의 가격과 개수로 계산한 총금액을 담을 변수
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                sum += a * b;
            }

            if (sum == x)
            {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }


        }
    }
}
