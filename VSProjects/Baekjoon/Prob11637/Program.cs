using System;

namespace Prob11637
{
    class Program
    {
        static void Main(string[] args)
        {
            // 투표 case T
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                bool flag = false; // 같은 득표수일때 처리를 위해 사용할 변수

                //후보자 n명 
                int n = int.Parse(Console.ReadLine());

                int[] getNum = new int[n];
                int sum = 0;
                int max = int.MinValue;
                int candidateNum = -1;


                //n명 후보자에 대한 득표수 입력
                for (int j = 0; j < n; j++)
                {
                    getNum[j] = int.Parse(Console.ReadLine());
                    sum += getNum[j];
                    if (max < getNum[j])
                    {
                        max = getNum[j];
                        candidateNum = j;
                    }
                }

                // 최대 득표수와 같은 득표수가 나온 경우
                int confirmNum = 0;
                for (int s = 0; s < n; s++)
                {
                    if (max == getNum[s])
                    {
                        confirmNum++;

                        if (confirmNum > 1) flag = true;
                    }

                    if (flag)
                    {
                        Console.WriteLine("no winner");
                        break;
                    }
                }

                // 같은 득표수가 나오지 않은 경우
                if (!flag)
                {
                    if (max < (sum / 2) + 1)
                    {
                        Console.WriteLine($"minority winner {candidateNum + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"majority winner {candidateNum + 1}");
                    }
                }
            }

        }
    }
}