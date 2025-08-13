namespace Prob1453
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            bool[] seat = new bool[101]; // 컴퓨터 자리 1~100 // 0번은 버린다.

            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            


            
            // 두번째 방법

            Array.Sort(input);

            for (int i = 0; i < n - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    cnt++;
                }
            }


            // 첫번째 방법

            //for (int i = 0; i < n; i++) // 앉고 싶어하는 자리를 bool 배열의 인덱스 값으로 넣는다.
            //{
            //    if (!seat[int.Parse(input[i])])
            //    {
            //        seat[int.Parse(input[i])] = true;
            //    }
            //    else
            //    {
            //        cnt++;
            //    }
            //}

            Console.WriteLine(cnt);

        }
    }
}
