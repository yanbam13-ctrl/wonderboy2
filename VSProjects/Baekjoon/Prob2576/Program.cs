namespace Prob2576
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7개의 자연수가 주어질때 (enter로 구분)
            //7개의 자연수 중 홀수들의 합을 구하고
            //홀수들 중 최소값을 찾기

            //ex ) 12, 77, 38, 41, 53, 92, 85 => 홀수의 합 = 77+41+53+85 = 256
            //최소값은 41
            //홀수가 존재 하지 않는 경우 첫째 줄에 -1을 출력

            int[] arr = new int[7];

            for (int i = 0; i < 7; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = -1;
            int min = int.MaxValue;

            foreach (var v in arr) {
                if (v % 2 != 0) {                    
                    sum += v;
                    if (min > v) {
                        min = v;
                    }
                }
            }

            if (sum != -1) {
                Console.WriteLine(sum+1);
                Console.WriteLine(min);
            }
            else{
                Console.WriteLine(sum);
            }


        }
    }
}
