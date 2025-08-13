namespace P198_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //첫 번째 수열 : 1
            //두 번째 수열 : 1이 1개 = 11
            //세 번째 수열 : 1이 2개 = 12
            //네 번째 수열 : 1이 1개, 2가 1개 = 1121
            //다섯 번째 수열 : 1이 2개, 2가 1개, 1이 1개 = 122111
            //여섯 번째 수열 : 1이 1개, 2가 2개, 1이 3개 = 112213
            //일곱번째 수열 : 1이 2개, 2가 2개, 1이 1개, 3이 1개 = 12221131

            string str = "1";
            string nextStr;

            Console.WriteLine($"1 : {str}");
            for (int i = 2; i <= 20; i++)
            {
                nextStr = "";
                int idx = 0;
                while (idx < str.Length)
                {
                    nextStr += str[idx].ToString();
                    int cnt = 1;
                    while (idx < str.Length - 1 && str[idx] == str[idx + 1])
                    {
                        idx++;
                        cnt++;
                    }
                    nextStr += cnt.ToString();
                    idx++;
                }
                str = nextStr;
                Console.WriteLine($"{i} : {str}");
            }


        }
    }
}
