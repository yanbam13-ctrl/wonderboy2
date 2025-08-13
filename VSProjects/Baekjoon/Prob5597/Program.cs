namespace Prob5597
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] students = new int[28];
            for(int i = 0; i < 28; i++)
            {
                students[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 30; i++)
            {
                bool found = false;
                for (int j = 0; j < students.Length; j++)
                {
                    if (i == students[j]) {
                        found = true;
                        break;
                    }
                }
                if (!found) {
                    Console.WriteLine(i);
                }
            }



            //28명의 출석번호를 입력 받는다. 어디에? -> bool[] student = new bool[31]; 1~30까지의 인덱스를 만들어 놓는다.

            //bool[] students = new bool[31];

            //for (int i = 0; i < 28; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());

            //    students[num] = true; // 2와 8이 입력이 안된 경우 students[2], studnets[8] 인덱스는 false 이다.
            //}

            //for (int i = 1; i < 31; i++) // 1부터 30까지의 숫자를 비교하여 제출 안한 학생 찾기
            //{
            //    if (!students[i]) {
            //        Console.WriteLine(i);
            //    }
            //}


            //int[] submitted = { 1, 2, 4 };

            //for (int i = 1; i <= 5; i++) {
            //    bool found = false;

            //    for (int j = 0; j < submitted.Length; j++) {
            //        if (i == submitted[j]) {
            //            found = true;
            //            break;
            //        }
            //    }
            //    if (!found) {
            //        Console.WriteLine(i);
            //    }
            //}


        }
    }
}

