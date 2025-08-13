using System;

namespace Prob10809_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 소문자 97 ~ 122
            // 대문자 65 ~ 90
            // 숫자 48 ~ 57
            // 공백 : 32

            int[] arr = new int[27]; // 0 ~ 26 까지 -> 1 ~ 26까지 사용
            //int a = 'b' - 96;

            //string input = Console.ReadLine();

            string input = "backjoon";

            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(input.IndexOf(i) + " ");
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = -1;
            //}

            //for (int i = 0; i < input.Length; i++)
            //{
            //    int num = input[i] - 96;
            //    if (arr[num] == -1)
            //    {
            //        arr[num] = i;
            //    }
            //}

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

        }
    }
}
