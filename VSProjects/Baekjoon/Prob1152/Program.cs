namespace Prob1152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //대소문자와 공백으로 이루어진 문자열 = str
            //이 문자열에 있는 단어 갯수 구하기
            //단어는 공백으로 구분됨 공백 +1 = 단어의 갯수

            //핵심은 공백 구하기
           
            string str = Console.ReadLine(); // 입력 받은 문자열

            // string 메서드로 입력된 문자열의 공백 제거
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(words.Length);
        }
    }
}

/*
 char space = ' '; // 공백 비교 기준 변수
            string str = Console.ReadLine(); // 입력 받은 문자열
            int res = 1; // 단어의 갯수를 넣기 위한 변수_ 공백 전의 처음 단어가 있기 때문에 1로 시작

            for (int i = 0; i < str.Length; i++)
            {
                if (space == str[i]) res++;
            }

            if (str[0] == space) res--;


            if (str[str.Length-1] == space) res--;
                Console.WriteLine(res); 

 */
