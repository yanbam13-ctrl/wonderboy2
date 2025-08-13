namespace Prob10820
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 소문자 97 ~ 122
            // 대문자 65 ~ 90
            // 숫자 48 ~ 57
            // 공백 : 32


            int[] resultArr = new int[4];
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null) break;


                char[] charArr = input.ToCharArray();

                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] >= 97)
                    {
                        resultArr[0]++;
                    }
                    else if (charArr[i] >= 65)
                    {
                        resultArr[1]++;
                    }
                    else if (charArr[i] >= 48)
                    {
                        resultArr[2]++;
                    }
                    else if (charArr[i] == 32) resultArr[3]++;
                }

                for (int i = 0; i < 4; i++)
                {
                    Console.Write(resultArr[i] + " ");
                    resultArr[i] = 0;
                }

                Console.WriteLine();
            }



        }
    }
}


