namespace Prob5063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //테스트 케이스의 개수 n을 입력 받는다.
            int n = int.Parse(Console.ReadLine());

            //다음n개의 줄에는 3개의 정수 r,e,c가 주어진다.
            //r은 광고를 하지 않았을때 수익
            //e는 광고를 했을때 수익
            //c는 광고 비용이다.
            //(e-c) - r = + 이면 advertise
            // - 이면 do not avertise
            // 0 이면 does not matter

            int res = -1;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int r = int.Parse(input[0]); 
                int e = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                res = (e - c) - r;

                if (res > 0)
                {
                    Console.WriteLine("advertise");
                }
                else if (res < 0)
                {
                    Console.WriteLine("do not advertise");
                }
                else {
                    Console.WriteLine("does not matter");
                }
            }
        }
    }
}
