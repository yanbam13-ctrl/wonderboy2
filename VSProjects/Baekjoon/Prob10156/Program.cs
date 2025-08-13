namespace Prob10156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int cal = a * b - c; // 300 * 4 - 1000 = -200
            int result = 0;

            if (cal > 0)
            {
                result = cal;
            }

            Console.WriteLine(result);

        }
    }
}

//=======


//namespace Prob10156
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] input = Console.ReadLine().Split();

//            int a = int.Parse(input[0]);
//            int b = int.Parse(input[1]);
//            int c = int.Parse(input[2]);
//            int cal = a * b - c; // 300 * 4 - 1000 = -200

//            if (cal > 0)
//            {
//                Console.WriteLine(cal);
//            }
//            else
//            {
//                Console.WriteLine(0);
//            }
//        }
//    }
//}

