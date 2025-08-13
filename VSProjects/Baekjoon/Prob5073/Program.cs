namespace Prob5073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //세변의 길이가 모두 같은 경우 Equilateral 
            //두변의 길이만 같은 경우 Isosceles 
            //세변의 길이가 모두 다른 경우 Scalene 
            //단 주어진 세 변의 길이가 삼각형의 조건을 만족하지 못하는 경우에는 "Invalid" 를 출력한다.
            //6 3 2 => max = 6; // 가장 긴 변의 길이보다 나머지 두 변의 길이의 합이 길지 않으면 삼각형의 조건을 만족하지 못한다.
            //max > 3 + 2


            while (true)
            {
                string[] input = Console.ReadLine().Split();

                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                if (a == 0 && b == 0 && c == 0) break;

                int max = a;
                int sum = b + c;

                if (max < b)
                {
                    max = b;
                    sum = a + c;
                }

                if (max < c)
                {
                    max = c;
                    sum = a + b;
                }

                //Console.WriteLine($"max : {max}, sum : {sum}");

                if (a == b && b == c)
                { //세변의 길이가 같은 경우
                    Console.WriteLine("Equilateral");
                }
                else if (max >= sum) // 조건이 안맞는 경우
                {
                    Console.WriteLine("Invalid");
                }

                else if (a == b || b == c || a == c) //두변의 길이만 같은 경우 
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Scalene");
                }
                //else if (a != b && b != c && a != c) //세변의 길이가 모두 다른 경우  
                //{
                //    Console.WriteLine("Scalene");
                //}

            }

        }
    }
}
