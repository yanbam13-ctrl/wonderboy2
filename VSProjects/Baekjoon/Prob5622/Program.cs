namespace Prob5622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      1 -> 2초
            //ABC = 2 -> 3초
            //DEF = 3 -> 4초
            //GHI = 4 -> 5초
            //JKL = 5 -> 6초
            //MNO = 6 -> 7초
            //PQRS =7 -> 8초
            //TUV = 8 -> 9초
            //WXYZ = 9 -> 10초
            //     = 0 -> 11초

            //ex ) WA -> 10 + 3 = 13초
            //ex ) UNUCIC -> 9 + 7 + 9 + 3 + 5 + 3 = 36초

            string input = Console.ReadLine();

            //string input = "UNUCIC";
            int res = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if ("ABC".Contains(input[i])) res += 3;
                else if ("DEF".Contains(input[i])) res += 4;
                else if ("GHI".Contains(input[i])) res += 5;
                else if ("JKL".Contains(input[i])) res += 6;
                else if ("MNO".Contains(input[i])) res += 7;
                else if ("PQRS".Contains(input[i])) res += 8;
                else if ("TUV".Contains(input[i])) res += 9;
                else if ("WXYZ".Contains(input[i])) res += 10;
                else res += 11;// 예외처리
            }

            Console.WriteLine(res);


        }
    }
}
