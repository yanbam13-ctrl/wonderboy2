namespace Prob2587
{
    internal class Program
    {
        ////선생님 풀이
        //static int GetAvg(int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }

        //    return sum / arr.Length;
        //}

        //static int GetCenter(int[] arr) {
        //    Array.Sort(arr);

        //    return arr[2];
        //}

        //재영 풀이//
        static int AvgCalculation(int[] arr)
        {

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
        static int NumCalculation(int[] arr)
        {
            Array.Sort(arr); // Hint
                             // 5개의 자연수가 주어진다.

            //0 1 2 3 4 -> 2번이 중앙값

            return arr[2];
        }


        static void Main(string[] args)
        {
            int n = 5;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                a[i] = int.Parse(input);
            }



            int avg = AvgCalculation(a);
            int centerNum = NumCalculation(a);

            Console.WriteLine(avg);
            Console.WriteLine(centerNum);

            //Console.WriteLine(GetAvg(a));
            //Console.WriteLine(GetCenter(a));

        }




    }
}
