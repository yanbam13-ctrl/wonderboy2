namespace Prob3052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            //int[] arr = { 0,0,0,0,0,0,0,0,0,0};

            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            int[] mod = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mod[i] = arr[i] % 42;
            }

            int result = 0;

            for (int i = 0; i < 10; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (mod[i] == mod[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    result++;
                }
            }

            Console.WriteLine(result);


        }

    }
}

/*

            int[] arr = new int[10];
            bool[] check = new bool[42];

            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //int[] arr = { 1,2,3,4,5,6,7,8,9,10 };

            for (int i = 0; i < arr.Length; i++)
            {
                int mod = arr[i] % 42;
                check[mod] = true;
            }

            int result = 0;
            for (int i = 0; i < check.Length; i++) {
                if (check[i]) result++;
            }

            Console.WriteLine(result); 

 */

/*

//int[] arr = new int[10];
        int count = 0;
        int result = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}

        int[] arr = { 39,40,41,0,1,2,40,41,0,1 };

        for (int i = 0; i < 9; i++) // 10의 인덱스가 있는 경우 0~8 까지 총 9개만 비교
        {
            int num = arr[i];

            for (int j = i + 1; j < 10; j++) // [0] 일때 비교 배열 인덱스는 [1] 이 되야 함. [i] == [i+1]
            {
                if (num == arr[j])
                {
                    count++; //arr배열 안에서 같은 수가 하나라도 있으면 count를 증가 시킴
                }
            }

            if (count != 0) // count가 0이 아니라면 같은 배열안에 같은 수가 있다는 의미 이므로 count 초기화
            {
                count = 0;
            }
            else
            { // count가 0이면 arr[i]와 같은 값을 갖는 나머지가 없다는 의미 이므로 result ++;
                result++;
            }
        }

        if (result == 0)
        {
            result = 1;
        }

        Console.WriteLine(result);





 */