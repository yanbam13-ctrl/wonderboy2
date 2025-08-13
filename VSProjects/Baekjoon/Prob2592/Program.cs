namespace Prob2592
{
    internal class Program
    {
        static int AvgCalculation(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        static int LotNumberCalculation(int[] arr)
        {
            //Array.Sort(arr);
            int[] verify = new int[arr.Length];
            int max = int.MinValue;

            //같은수가 몇개인지 확인해서 verfiy 중복된 숫자를 담는다.
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        verify[i]++;
                    }
                }
            }

            //verify 배열 중에 제일 높은 값을 가지는 인덱스를 출력

            for (int i = 0; i < verify.Length; i++)
            {
                if (max < verify[i])
                    max = i;
            }

            return arr[max];
        }

        //static int GetMode2(int[] arr, int n)
        //{
        //    int[] cnt = new int[n];
        //    Array.Sort(arr);

        //    cnt[0] = 1;
        //    for (int i = 1; i < n; i++)
        //    {
        //        if (arr[i - 1] == arr[i])
        //        {
        //            cnt[i] = cnt[i - 1] + 1;
        //        }
        //    }
        //}



        static void Main(string[] args)
        {
            int n = 10;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                a[i] = int.Parse(input);
            }

            int avg = AvgCalculation(a);
            int lotNumber = LotNumberCalculation(a);

            Console.WriteLine(avg);
            Console.WriteLine(lotNumber);

        }
    }
}
