namespace P100_VarKeyword
{
    internal class Program
    {
        //var number2 = 200; // 멤버변수에 var 사용 x
        static void Main(string[] args)
        {
            var number = 100;
            Console.WriteLine(number.GetType());

            //number = 200;
            Console.WriteLine(number.GetType());

            //number = "변경"; // 타입 변경 x

            //var number2; // 초기값 없으면 x

            
        }
    }
}
