namespace Prob3052_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = new int[10];
            int[] modArr = new int[10];

            //나머지값 입력 받기
            for (int i = 0; i < 10; i++)
            {
                inputArr[i] = int.Parse(Console.ReadLine());
            }

            // 나머지 값 구하기
            for (int i = 0; i < 10; i++)
            {
                modArr[i] = inputArr[i] % 42;
            }


            bool[] check = new bool[42]; // 0~41까지의 나머지가 있는지 확인 하기 위한 배열
            int result = 0;

            for (int i = 0; i < 10; i++) {
                check[modArr[i]] = true;
            }

            for (int i = 0; i < 42; i++) {
                if (check[i]) result++;
            }

            Console.WriteLine(result);


        }
    }
}

/*
 
            // 10개의 숫자를 입력 받는다. 
            // 입력 받은 숫자를 42로 나눈 나머지를 구한다.
            // 나머지들간 서로 다른 값이 몇개 있는지 출력한다.

            // 입력값 -> 나머지 계산 -> 중복제거 -> 고유한 값 개수 세기

            int[] inputArr = new int[10];
            int[] modArr = new int[10];

            //나머지값 입력 받기
            for (int i = 0; i < 10; i++)
            {
                inputArr[i] = int.Parse(Console.ReadLine());
            }

            // 나머지 값 구하기
            for (int i = 0; i < 10; i++)
            {
                modArr[i] = inputArr[i] % 42;
            }

            int result = 0; // 중복된 값이 없다면 ++

            // == 비교 ==
            //39, 40, 41, 0, 1, 2, 40, 41, 0, 1

            //modArr[0] 39 -> 비교 x
            //modArr[1] == modArr[0] -> 40 == 39
            //modArr[2] == modArr[0,1]  -> 41 == 39, 40
            //modArr[3] == modArr[0,1,2]  -> 0 == 39, 40, 41, 
            //modArr[4] == modArr[0,1,2,3]  -> 1 == 39, 40, 41, 0, 
            //modArr[5] == modArr[0,1,2,3,4]  -> 2 == 39, 40, 41, 0, 1, 
            //modArr[6] == modArr[0,1,2,3,4,5]  -> 40 == 39, 40, 41, 0, 1, 2,
            //modArr[7] == modArr[0,1,2,3,4,5,6]  -> 41 == 39, 40, 41, 0, 1, 2, 40,
            //modArr[8] == modArr[0,1,2,3,4,5,6,7]  -> 0 == 39, 40, 41, 0, 1, 2, 40, 41, 
            //modArr[9] == modArr[0,1,2,3,4,5,6,7,8]  -> 1 == 39, 40, 41, 0, 1, 2, 40, 41, 0, 


            for (int i = 0; i < 10; i++)
            {
                bool isDuplicate = false; // isDuplicate 가 false 일때 result가 실행됨 // i가 0일때 무조건 result ++
                // i가 0일 때는 비교 대상이 없으므로 중복이 없다고 판단하여 result가 증가함

                for (int j = 0; j < i; j++) // 현재 modArr[i] 값을 modArr[0]부터 modArr[i-1]까지 비교하여 중복 여부 확인
                {
                    if (modArr[i] == modArr[j]) // modArr배열에 i인덱스와 일치하는 값이 있다면 
                    {                           
                        isDuplicate = true; // result를 증가 시키지 않고 [중복되지 않는 값을 찾기 위해서임]
                        break;             // 만약 이전에 같은 나머지 값이 있다면 중복으로 판단하고 반복문 종료
                    }

                }
                    if (!isDuplicate) result++; //내부 반복문에서 중복되는 숫자가 없다면 modArr[i]의 값은 서로 다른 값이므로 result++;

            }

            Console.WriteLine(result); 


 */
