namespace PPT15_FunctionParameter
{
    internal class Program
    {
        static void SumAtoB(int a, int b)
        {
            int sum = 0;

            for (int i = a; i <= b; i++) {
                sum += i;
            }

            Console.WriteLine(sum);
            
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            ShowMessage("매개변수");
            ShowMessage("Parameter");

            //두 수 a와 b를 매개변수로 입력 받아  a ~ b수의 합을 출력하는 메서드

            SumAtoB(1, 10);
        }
    }
}
