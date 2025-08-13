using System;
using static System.Net.Mime.MediaTypeNames;
namespace Prob1181
{
    internal class Program
    {
        static string[] RemoveDuplicateArray(string[] input)
        {
            string[] temp = new string[input.Length];
            int cnt = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < cnt; j++)
                {
                    if (input[i] == temp[j])
                    {
                        //중복이 확인된다면 temp에 input[i] 값을 저장 하지 않는다.
                        isDuplicate = true;
                        break;
                    }
                }
                // input[i]값이 중복이 아니라면 temp[cnt]에 저장한다.
                if (!isDuplicate)
                {
                    temp[cnt] = input[i];
                    cnt++;
                }
            }


            //temp에 중복된 값을 담았다면 temp에 자료가 담겨 있는 수 = cnt 크기의 배열을 받아서 옮겨준다.
            string[] resArr = new string[cnt];

            for (int i = 0; i < cnt; i++)
            {
                resArr[i] = temp[i];
            }

            return resArr;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }

            //중복값을 제거한 새로운 배열을 리턴해준다.
            string[] removeArray = RemoveDuplicateArray(input);

            //길이가 짧은 순서대로 정렬
            Array.Sort(removeArray, (a, b) =>
            {

                if (a.Length != b.Length) return a.Length.CompareTo(b.Length);

                else
                    return a.CompareTo(b);
                //if (a.Length != b.Length) return
            });


            for (int i = 0; i < removeArray.Length; i++) {
                Console.WriteLine(removeArray[i]);
            }


        }
    }
}
