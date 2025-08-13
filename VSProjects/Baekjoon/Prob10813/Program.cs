namespace Prob10813
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 첫번째 입력 ex) n = 5 , n = 4 <- 5개의 바구니 / 4개의 교환 횟수
            //5개의 인덱스가 있는 배열을 생성

            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            //n개의 인덱스를 갖는 배열 생성
            int[] arr = new int[n];

            //배열의 값 초기화
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }


            for (int i = 0; i < m; i++)
            {
                string[] inputSecond = Console.ReadLine().Split();

                int a = int.Parse(inputSecond[0]);
                int b = int.Parse(inputSecond[1]);

                int empty = arr[a - 1];
                arr[a - 1] = arr[b - 1];
                arr[b - 1] = empty;

            }


            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();



        }
    }
}
