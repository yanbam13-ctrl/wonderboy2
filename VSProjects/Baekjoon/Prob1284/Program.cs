namespace Prob1284
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 숫자 사이 1cm 여백
            // 1은 2cm 너비
            // 0은 4cm 너비
            // 나머지 수는 3cm 너비
            // 호수판의 경계와 숫자 사이에는 1cm의 여백



            while (true)
            {
                string n = Console.ReadLine();
                if (n[0] == '0') break;

                int res = 2; // 호수판의 경계와 숫자 사이 2cm;-> 기본 값

                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] == '0')
                    {
                        res += 4;
                    }
                    else if (n[i] == '1')
                    {
                        res += 2;
                    }
                    else
                    {
                        res += 3;
                    }

                    if (i != n.Length - 1)
                    {
                        res += 1;
                    }
                }

                Console.WriteLine(res);
            }
        }
    }
}
