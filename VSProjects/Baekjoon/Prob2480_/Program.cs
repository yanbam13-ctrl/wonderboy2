namespace Prob2480_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3개의 숫자를 비교하여
            // 같은 눈 3개가 나오면 10,000  + (같은 눈) x 1000; => 2 2 2 => 12,000
            // 같은 눈 2개가 나오면 1,000  + (같은 눈) x 100; => 3 3 6 => 1,300
            // 모두 다른 눈이 나오는 경우  + (가장 큰 눈) x 100; => 6 2 5 => 600

            string[] input = Console.ReadLine().Split();
            int[] num = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                num[i] = int.Parse(input[i]);
            }

            Array.Sort(num); // 입력 받은 값을 오름차순으로 정렬

            int result = 0;//결과값

            //모두 같은지 비교하기
            if (num[0] == num[1] && num[1] == num[2]) //3 3 6 => 3 == 3 && 3 == 6;
            {
                result = 10000 + (num[0] * 1000);
            }

            //2개만 같은 경우
            else if ((num[0] == num[1]) || num[1] == num[2]) // 정렬 되어 있으므로 0 이랑 1이 같지 않다면/ 1이랑 2가 같은 경우
            {                

                result = 1000 + (num[1] * 100); // 정렬 되어 있으므로 num[1]이 같은 수의 기준이 된다.

            }
            //모두 다른 경우

            else 
            {
                result = num[2] * 100;
            }

            Console.WriteLine(result);

        }
    }
}
