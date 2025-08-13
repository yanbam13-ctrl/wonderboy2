namespace Prob1193
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine()); // 입력 값                        // 2일때
            int getNum = x; //x가 7일때 4     //몇번째 대각선인지 구하기               // 2


            // getNum이 짝수이면 위에서 아래, 홀수이면 아래에서 위

            // 7 - 1 = 6, 6 - 2 = 4, 4 -3 = 1, 1 - 4 = -3;
            //몇번째 대각선인지 구함
            // 7이면 4, 예외로 2일때는 2 
            for (int i = 1; i <= x; i++)
            {
                getNum -= i;
                if (getNum <= 0)
                {
                    getNum = i;
                    break;
                }
            }

            int endNum = 0;
            int startNum = 1;

            int n = getNum + 1; // x위치에 있는 분수와 분모의 합                       

            for (int i = 1; i <= getNum; i++)
            {
                //끝값
                endNum += i;

                //시작값
                if (i != getNum)
                {
                    startNum += i;
                }
            }

            int firstNum = 0;
            int lastNum = 0;
            int temp = 0;

            if (getNum % 2 == 0)
            {
                //위에서 아래로

                //n이 4일때

                // 7 % startNum 0 - > 1 / (n)
                // 8 % startNum 1 -> 1+1 / n-1
                // 9 % startNum 2 -> 1+1+1 / n - 1 - 1
                // 10 % startNum 3 -> 1+1+1+1 / n - 1 - 1- 1

                firstNum = (x % startNum) + 1; // 5 - ( 7 % 5 = 2) -> 3 
                lastNum = getNum - (x % startNum);

            }
            else
            {

                firstNum = getNum - (x % startNum); 
                lastNum = (x % startNum) + 1;



            }

            Console.WriteLine(firstNum + "/" + lastNum);



            //대각선 자리수의 끝값은 4일경우 1 + 2 + 3 + 4 = 10; 대각선에서 제일 큰수 -> 끝자리 수
            //대각선 자리수의 시작 값은 4일 경우 1 + 2 + 3 + 1 = 7;
            //대각선 자리수의 방향은 대각선 순서가 짝수이면 위에서 아래로, 홀수이면 아래에서 위로
            // 7은 n번째 대각선 즉 4번째 대각선에 위치하며 4번째 대각선의 시작은 7이고, 마지막은 10이다.
            // 7 부터 10까지 7 , 8 ,9 ,10 총 4개의 숫자가 있으며 10 - 7 + 1이 대각선에 위치한 숫자들의 갯수이다.
            // 4번째 대각선에서 분수의 합은 n+1 즉 5가 되며 
            // 시작 값은 1/4 , 끝값은 4/1이다.

        }
    }
}
