namespace Prob2588
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input_a = Console.ReadLine(); // 472
            string input_b = Console.ReadLine(); // 385
            int a = int.Parse(input_a);
            int b = int.Parse(input_b);

            int c = a * (b % 10);
            int d = a * ((b / 10) % 10);
            int e = a * (b / 100);

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(a * b);


            // ============================== //
            //string input_a = Console.ReadLine();
            //string input_b = Console.ReadLine();

            ////입력받은 첫번째 줄 숫자 변수
            //int a = int.Parse(input_a);
            //int b = int.Parse(input_b);


            //for (int i = input_b.Length - 1; i >= 0; i--)
            //{
            //    int n = int.Parse(input_b[i].ToString());
            //    Console.WriteLine(a * n);
            //}
            //Console.WriteLine(a * b);

            // ========================= //
            //string input_a = Console.ReadLine();
            //string input_b = Console.ReadLine();

            ////입력받은 첫번째 줄 숫자 변수
            //int a = int.Parse(input_a);
            //int b = int.Parse(input_b);

            ////입력받은 두번째 줄 숫자 변수 3자리인 경우 끝자리 부터 하나씩 추출
            //// string으로 입력받은 값은 "" string 타입으로 문자열을 하나씩 나누면 char타입이 됨. char 타입을 int.Parse()로 하려면
            //// Tostring()을 사용하여 string 값으로 변경 해야함.
            //int lenNum = input_b.Length-1;   
            //int bEndNum = int.Parse(input_b[lenNum].ToString());
            //int bMidNum = int.Parse(input_b[lenNum].ToString());
            //int bFirstNum = int.Parse(input_b[lenNum-2].ToString());

            //Console.WriteLine(a * bEndNum);
            //Console.WriteLine(a * bMidNum);
            //Console.WriteLine(a * bFirstNum);
            //Console.WriteLine(a * b);

        }
    }
}
