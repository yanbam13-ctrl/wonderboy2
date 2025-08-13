namespace Prob2908
{
    internal class Program
    {
        // 상근이 동생 상수가 수학 공부를 못하는게 문제임
        // 734 vs 893 이라고 적힌 수를
        // 437 vs 398 이라고 읽는데여 '상수가'
        //상수 문제가 심각하네

        //첫째줄에 상근이가 칠판에 적은 a와b 두수가 주어짐 (세자리 이며 0이 포함되지 않음)
        //상수의 대답을 출력한다.

        // 입력값 자리 바꾸기 한후 
        // 크기 비교해서 
        // 큰 수를 출력

        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();

            int a = int.Parse(new string(input[0].Reverse().ToArray()));
            int b = int.Parse(new string(input[1].Reverse().ToArray()));

            Console.WriteLine(a > b ? a : b);


            //char[] upNum = new char[input[0].Length];
            //char[] downNum = new char[input[1].Length];


            //for (int i = 0; i < input[0].Length; i++)
            //{
            //    upNum[i] = input[0][(input[0].Length - 1) - i];
            //}

            //for (int i = 0; i < input[1].Length; i++)
            //{
            //    downNum[i] = input[1][(input[1].Length - 1) - i];
            //}


            //int resA = int.Parse(new String(upNum));
            //int resB = int.Parse(new String(downNum));

            //if (resA > resB)
            //{
            //    Console.WriteLine(resA);
            //}
            //else
            //{
            //    Console.WriteLine(resB);
            //}
        }





        //string[] input = Console.ReadLine().Split();

        //char[] a = input[0].ToCharArray();
        //char[] b = input[1].ToCharArray();

        //char[] upNum = new char[a.Length];
        //char[] downNum = new char[b.Length];

        //for (int i = 0; i < a.Length; i++)
        //{
        //    upNum[i] = a[(a.Length - 1)-i]; 
        //}

        //int resA = int.Parse(upNum);

        //Console.WriteLine(resA);

    }
}

