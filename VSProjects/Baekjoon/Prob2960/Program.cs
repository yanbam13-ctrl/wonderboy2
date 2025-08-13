namespace Prob2960
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int p = int.MaxValue;
            int cnt = 0;
            int[] arr = new int[n + 1];
            bool[] isDeleted = new bool[n + 1];
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = i;
                isDeleted[i] = true;
            }

            while (cnt != k)
            {
                //최소값 구하기 = p 구하기

                for (int i = 2; i <= n; i++)
                {
                    if (isDeleted[i] && p > i)
                    {
                        if (IsPrimbe(i))
                        {
                            p = i;
                        }
                    }
                }

                //구하고 나서 p부터 p의 배수 지우기
                for (int i = 1; i < n; i++)
                {
                    if ((i * p) <= n && isDeleted[i * p])
                    {
                        isDeleted[i * p] = false;
                        cnt++;

                        if (cnt == k)
                        {
                            result = i * p;
                        }
                    }
                }
                p = int.MaxValue;
            }

            Console.WriteLine(result);

            //for (int i = 2; i <= n; i++)
            //{
            //    Console.Write(isDeleted[i] + " ");
            //}

        }

        static bool IsPrimbe(int n) // 소수 구하는 함수
        {
            if (n < 2) return false; // 0과 1 제외

            for (int i = 2; i * i <= n; i++) // 소수 아닌 수 확인하기
            {
                if (n % i == 0) // 4 6 8 10 12 14 16 18 20 ... 으로 n이 나누어 떨어진다면 소수가 아니다.
                {
                    return false;
                }
            }
            return true; // 소수가 아닌수 검증에서 걸러지지 않음. 즉 소수임.
        }


    }
}
