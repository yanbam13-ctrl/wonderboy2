namespace PPT32_FunctionAddNumbers
{
    internal class Program
    {
        /// <summary>
        /// 두 수를 더하여 그 결과값을 변환시켜 주는 함수
        /// </summary>
        /// <param name="a">첫 번째 매개변수</param>
        /// <param name="b">두 번째 매개변수</param>
        /// <returns>a + b 결과</returns>
        static int AddNumber(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {

            int a = 3;
            int b = 5;
            int c = AddNumber(a, b);

            Console.WriteLine($"{a} + {b} = {c}");
        }
    }
}
