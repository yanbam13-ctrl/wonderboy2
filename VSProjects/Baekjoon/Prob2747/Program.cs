namespace Prob2747
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //피보나치 수는 0과 1로 시작
            //0번째 피보나치 수는 0이고, 1번째 피보나치 수는 1이다.
            //그 다음 2번째 부터는 바로 앞 두 피보나치 수의 합이 된다. 0 + 1 = 2?
            //F[n] = F[n-1] + F[n-2]
            //n = 17일때
            //0, 1, 1 , 2, 3, 5, 8, 13, 21,34, 55, 89, 144, 233, 377, 610, 987, 1597
            //f[0] = 0
            //f[1] = 1
            //f[2] = 1
            //f[3] = 2
            //f[4] = 3
            //f[5] = 5
            //f[6] = 8
            //f[7] = 13
            //f[8] = 21
            //f[9] = 34
            //f[10] = 55

            int startNum = 0;
            int secondNum = 1;
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n + 1];

            arr[0] = startNum;
            arr[1] = secondNum;

            for (int i = 2; i < n + 1; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            Console.WriteLine(arr[n]);





        }
    }
}
