namespace Prob1546
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 세준이의 평균 점수 조작
            // 최대값 고르기 = m;
            // 모든 점수를 점수 / m * 100 
            // ex) m = 70 , 50/70*100 = 71.43

            //첫째 줄에 시험 본 과목의 개수 n개가 주어짐
            //둘째 줄에 세준이의 현재 성적이 주어짐

            //첫째줄에 새로운 평균을 출력 한다.

            //3
            //40 80 60
            //75.0
            // => m = 80,
            // 40/80 * 100 =50,
            // 80/80 * 100 = 100,
            // 60/80 * 100 = 75
            // => 225/3 => 75

            //int m = 3;

            //int a = 40;
            //int b = 80;
            //int c = 60;

            int m = int.Parse(Console.ReadLine());

            string[] inputArr = Console.ReadLine().Split();

            int[] scoreArr = Array.ConvertAll(inputArr, int.Parse);

            int max = scoreArr[0];
            float sum = 0;

            for (int i = 1; i < m; i++)
            {
                //최대값 구하기
                if (max < scoreArr[i]) max = scoreArr[i];
            }

            float[] newScoreArr = new float[m];

            for (int i = 0; i < m; i++)
            {
                newScoreArr[i] = ((scoreArr[i] / (float)max) * 100);
            }


            for (int i = 0; i < m; i++)
            {
                //Console.WriteLine(newScoreArr[i]);
                sum += newScoreArr[i];
            }

            Console.WriteLine(sum/m);

            



        }
    }
}
