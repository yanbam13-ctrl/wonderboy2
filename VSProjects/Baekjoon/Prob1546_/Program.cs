using System.ComponentModel.DataAnnotations;

namespace Prob1546_
{
    internal class Program
    {
        //static int[] a;
        //static int n;

        static int[] Input()
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            input = Console.ReadLine();
            string[] arrInput = input.Split();

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arrInput[i]);
            }

            return a;
        }

        static float Process(int[] a, int n)
        {
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                sum += a[i];
                if (max < a[i]) max = a[i];
            }
            float avg = (float)sum / n;
            float res = avg / max * 100;

            return res;
        }

        static void Main(string[] args)
        {
            int[] a = Input();
            int n = a.Length;

            float res = Process(a, n);

            Console.WriteLine(res);
        }
    }
}


//static int Max(int[] a)
//{
//    int max = int.MinValue;

//    for (int i = 0; i < a.Length; i++)
//    {
//        if (a[i] > max) max = a[i];
//    }

//    return max;
//}

//string input = Console.ReadLine();
//int n = int.Parse(input);

//input = Console.ReadLine();
//string[] arrInput = input.Split();

//int[] a = new int[n];
//for (int i = 0; i < n; i++)
//{
//    a[i] = int.Parse(arrInput[i]);
//}

////코드 작성
//int max = Max(a); // 최대값
//float sum = 0;
//for (int i = 0; i < a.Length; i++)
//{
//    sum += ((float)(a[i]) / max) * 100;
//}

//Console.WriteLine(sum / a.Length);