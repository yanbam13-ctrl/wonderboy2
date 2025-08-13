namespace Prob15964
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            //long a = long.Parse(input[0]);
            //long b = long.Parse(input[1]);

            //long result = (a + b) * (a - b);

            //result가 가장 커지는 경우 a = 100,000 , b = 1;
            // 100,001 * 9999 = 9,999,999,999 -> 99억이 넘어 가므로
            // 결과값이 int의 범위를 넘어가게 된다.

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            long result = (a + b) * (long)(a - b);// int로 입력 받아서 메모리 효율을 높이고
                                                  // 입력받은 값중 하나의 수식 결과 값만 long으로 바꿔줘도 result 변수에 담을 수 있게 된다.

            Console.WriteLine(result);
            
        }
    }
}

//namespace Prob15964
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] input = Console.ReadLine().Split();

//            long a = long.Parse(input[0]);
//            long b = long.Parse(input[1]);

//            long result = a * a - b * b;

//            Console.WriteLine(result);

//        }
//    }
//}
