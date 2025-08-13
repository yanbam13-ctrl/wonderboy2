namespace Prob2675
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 케이스 입력 int
            // 반복 회수 입력 한칸 띄고 문자열
            // 반복되는 문자열 P 출력

            //케이스 입력
            int n = int.Parse(Console.ReadLine());

            string[] res = new string[n];
            //케이스 만큼 입력 받기
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                res[i] = ""; // 초기화 추가

                int r = input[0] - '0'; // 가독성을 위해 '0' 사용

                for (int h = 2; h < input.Length; h++) // 입력 받은 문자의 갯수만큼 반복 0, 1 인덱스는 제외
                {
                    //입력받은 첫번째 인덱스를 문자에서 숫자로 바꾸기 위해 - 48 // 0의 아스키코드는 48
                    for (int j = 0; j < r; j++)
                    {
                        res[i] += input[h];
                    }
                }
            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
