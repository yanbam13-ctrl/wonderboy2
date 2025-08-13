namespace Prob2577
{
    internal class Program
    {
        static int GetSum()
        {
            string input = Console.ReadLine();
            int a = int.Parse(input);

            input = Console.ReadLine();
            int b = int.Parse(input);

            input = Console.ReadLine();
            int c = int.Parse(input);

            return a * b * c;
        }
        static int[] ConvertArray(int sum)
        {
            string strNum = sum.ToString();
            char[] charArray = strNum.ToCharArray();
            int[] numArr = new int[strNum.Length];

            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = charArray[i] - '0';
            }

            return numArr;
        }

        static void Solve(int[] numArr)
        {
            int[] cntArray = new int[10];

            for (int i = 0; i < numArr.Length; i++)
            {
                cntArray[numArr[i]]++;
            }

            for (int i = 0; i < cntArray.Length; i++)
            {
                Console.WriteLine(cntArray[i]);
            }
        }
        static void Main(string[] args)
        {
            int sum = GetSum(); // 입력 받고, 합계 구하기
            int[] numArr = ConvertArray(sum); // 합계 숫자를 한개씩 쪼개서 배열에 담기
            Solve(numArr); // 0~9 까지 사용된 숫자를 카운터 후 출력

        }
    }
}
