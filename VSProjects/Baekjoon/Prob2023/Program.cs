namespace Prob2023
{
    internal class Program
    {
        static int n;


        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            int[] firstPrimes = { 2, 3, 5, 7 };

            foreach (int prime in firstPrimes)
            {
                DFS(prime, 1);
            }
        }

        static void DFS(int num, int length)
        {
            if (length == n)
            {
                Console.WriteLine(num);
                return;
            }

            for (int i = 1; i <= 9; i += 2) // 끝자리는 홀수만
            {
                int next = num * 10 + i;
                if (IsPrime(next))
                {
                    DFS(next, length + 1);
                }
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;

        }
        
    }

}
/*

 //n이 1일때 10 -> 100 보다 작다의 100을 구해야함. s * 10
            //n이 2일때 100 -> 1000 보다 작다의 1000을 구해야함.
            //n이 3일때 1000
            //n이 4일때 10000
            //n이 5일때 100000

            int n = int.Parse(Console.ReadLine());
            int s = (int)Math.Pow(10, n - 1); // 10의 n승 -> double 반환함
                                              //int s = 1;

            //n의 자리수 만큼 만드는 방법
            //for (int i = 1; i < n; i++)
            //{
            //    s *= 10;
            //}

            // 1000 일때
            // 1000 -> 1 , 10, 100, 1000 이 소수인지 확인하여 모두 소수이면 출력
            // 

            // 1000일때 1, 10, 100, 1000을 구하기 위해서
            // 1000 / 1000 = 1,
            // 1000 / 100 = 10,
            // 1000 / 10 = 100,
            // 1000 / 1 = 1000,

            int cnt = 0;
            int[] arr = new int[s * 10];
            bool flag = false;

            for (int i = s; i < s * 10; i++) // n이 4일때, 시작 값은 1000 끝값은 10000;
            {
                flag = true;

                for (int j = n; j > 0; j--) // n이 4일 때, j = 4로 시작
                {                    
                    int a = 0;
                    if (j != 1)
                    {
                        a = i / (int)Math.Pow(10, (j - 1)); // i는 1이고,
                                                            // j는 4일때 1000 / 1000 -> 1
                                                            // j는 3일때 1000 / 100 -> 10
                                                            // j는 2일때 1000 / 10 -> 100
                                                            // j는 1일때 1000 / 1 -> 1000         
                    }
                    else
                    {
                        a = i ;
                    }

                    if (!IsPrime(a))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    arr[cnt] = i;
                    cnt++;
                }

            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        // 소수 구하는 함수
        // 소수의 조건 
        // 1보다 큰 자연수 이며 1과 자기 자신만을 약수로 가지는 수
        // IsPrime() 함수 만듬

        static bool IsPrime(int n) // 소수 구하는 함수
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
 

 */