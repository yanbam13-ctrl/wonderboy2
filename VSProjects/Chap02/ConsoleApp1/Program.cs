namespace P123_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 12번 문제
            string input = Console.ReadLine();

            //Console.WriteLine("입력한 값은" + input + "kg 입니다.");
            Console.WriteLine((int.Parse(input) * 2.20462262) + " pound");

            // 11번 문제
            //string input = Console.ReadLine();
            //double a = 2 * 3.14 * int.Parse(input);//둘레
            //double b = 3.14 * (int.Parse(input)) * (int.Parse(input));//넓이

            //Console.WriteLine("입력한 값은 반지름의 값은" + input + " 입니다.");
            //Console.WriteLine("둘레 : " + a.ToString("00.00"));
            //Console.WriteLine("넓이 : " + b);

        }
    }
}

// 11번 문제
//string input = Console.ReadLine();
//Console.WriteLine("입력한 값은" + input + " inch 입니다.");
//Console.WriteLine((int.Parse(input) * 2.54) + " cm");

// 12번 문제
//string input = Console.ReadLine();

//Console.WriteLine("입력한 값은" + input + "kg 입니다.");
//Console.WriteLine((int.Parse(input) * 2.20462262) + " pound");
