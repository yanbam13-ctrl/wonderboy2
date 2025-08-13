namespace Prob2480
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 3 6 -> 1300 //  1,000 + 3 * 100
            // 2 2 2 -> 12000 //10,000 + 2 * 1000
            // 6 2 5 -> 600 // 6 * 100

            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int prizeMoney = 0;

            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            if ((a == b) && (a == c))
            {
                prizeMoney = 10000 + a * 1000;
            }
            else if ((a == b) || (a == c))
            {
                prizeMoney = 1000 + a * 100;
            }
            else if (b == c)
            {
                prizeMoney = 1000 + b * 100;
            }
            else {
                prizeMoney = max * 100;
            }

                Console.WriteLine(prizeMoney);


        }
    }
}
//namespace Prob2480
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // 3 3 6 -> 1300
//            // 2 2 2 -> 12000
//            // 6 2 5 -> 600

//            string[] input = Console.ReadLine().Split();

//            int a = int.Parse(input[0]);
//            int b = int.Parse(input[1]);
//            int c = int.Parse(input[2]);
//            int prizeMoney = 0;

//            if ((a == b) && (a == c))
//            {
//                prizeMoney = 10000 + a * 1000;
//            }
//            else if ((a == b) || (a == c) || (b == c))
//            {
//                if ((a == b) || (a == c))
//                {
//                    prizeMoney = 1000 + a * 100;
//                }
//                else
//                {
//                    prizeMoney = 1000 + c * 100;
//                }
//            }
//            else
//            {
//                if ((a > b) && (a > c))
//                {
//                    //a가 제일 큰 경우
//                    prizeMoney = a * 100;
//                }
//                else if ((b > a) && (b > c))
//                {
//                    prizeMoney = b * 100;
//                }
//                else
//                {
//                    prizeMoney = c * 100;

//                }
//            }

//            Console.WriteLine(prizeMoney);
//        }
//    }
//}
