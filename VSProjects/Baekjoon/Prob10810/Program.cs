namespace Prob10810
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int arrLen = int.Parse(input[0]); // 바구니 갯수
            int arrCount = int.Parse(input[1]); // 공 넣는 횟수

            int[] arr = new int[arrLen]; // 바구니 배열 만들기

            // 처음 입력받은 배열의 크기에 맞게 0으로 초기화 = arrLen(배열 크기)
            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = 0;
            }

            // 바구니에 공을 넣는 횟수 arrCount 에 따라 값을 입력 받음

            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < arrCount; i++)
            {
                string[] inputSecond = Console.ReadLine().Split();
                a = int.Parse(inputSecond[0]); // 시작 바구니
                b = int.Parse(inputSecond[1]); // 끝 바구니
                c = int.Parse(inputSecond[2]); // 공 번호

                for (int j = a; j < b + 1; j++)
                {
                    //Console.WriteLine($"내부 for문 {i}번째 발동");
                    //Console.WriteLine($"{a} {b} {c}");
                    arr[j-1] = c;
                    //Console.WriteLine($"arr[{j}] : {arr[j]}");

                }

            }

            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write($"{arr[x]} ");
            }
            Console.WriteLine();

        }
    }
}
