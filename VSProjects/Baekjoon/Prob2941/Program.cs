namespace Prob2941
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //첫째 줄에 최대 100글자의 단어가 주어진다.

            //ljes=njak

            //  c=
            //  c-

            //  dz=
            //  d-

            //  lj

            //  nj

            //  s=
            //  z=

            string str = Console.ReadLine();

            //string str = "ljes=njak";
            //string str = "ddz=z=";
            //string str = "c=c=";
            //string str = "nljj";
            //string str = "dz=ak";

            int n = str.Length;
            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                string confirm = "";
                if (str[i] == '=') // 문자열 중 '=' 이 있다면
                {
                    if (i >= 2) // 문자열 3번 인덱스 이상일 경우만 'dz=' // 에러 막아주기
                    {
                        confirm = str.Substring(i - 2, 3);
                    }

                    if (confirm == "dz=") // 문자열 3번 인덱스이 이상일때 confirm에 = 기준 -2 인덱스 부터 3자리 문자열 비교
                        cnt += 2; // dz= 일때

                    else cnt++; //c=, s=, z= 일때
                }
                else if (str[i] == '-')
                {
                    cnt++; // c-, d- 일때
                }
                else if (str[i] == 'j')
                {
                    if (i >= 1) // 문자열 2번 인덱스 이상일 경우만 'lj' , 'nj' // 에러 막아주기
                    {
                        confirm = str.Substring(i - 1, 2);
                    }
                    if (confirm == "lj" || confirm == "nj") cnt++;
                }
            }

            Console.WriteLine(str.Length - cnt);





        }
    }
}
