namespace Prob2839_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N kg의 설탕 배달하기
            //5kg 봉지를 최대한 많이 활용하여 3kg 봉지와 섞어서 배달할때 N kg을 담을수 있는 봉지수는?
            //N kg을 봉지에 담을수 없는 경우에는 -1을 출력

            int n = int.Parse(Console.ReadLine());
            //int n = 6;
            int result = -1;

            for (int five = n / 5; five >= 0; five--)
            {
                int remain = n - (five * 5);

                if (remain % 3 == 0) {
                    int three = remain / 3;
                    result = five + three;
                    break;
                }
            }

            Console.WriteLine(result);



        }
    }
}


/*
 
 int n = 12;
            int result = -1;

            for (int five = n / 5; five >= 0; five--)
            {
                int remain = n - five * 5;
                if (remain % 3 == 0)
                {
                    int three = remain / 3;
                    result = five + three;
                    break;
                }
            }

            Console.WriteLine(result);

 */

/*

 int n = 4;
            int result = -1;

            for (int i = 0; i < n; i++) // i = 0
            {

                int five = (n - (5 * i)) / 5; // = 0 // 0 // 4-10 /5 = - 1 //

                if ((n - (5 * i) % 5 == 0)) //false 
                {
                    result = five;
                    break;
                }

                int review = n - (five * 5); //4 - 0 // 4 - 0//  4- - 1

                if (review % 3 == 0) //false
                { 
                    result = (review / 3) + five; // 2 + 0
                    break;
                }
            }

            Console.WriteLine(result); 

 */