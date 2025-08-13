namespace Prob10809
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //baekjoon -> 0 1 2 3 4 5 6 7
            //
            //1.a 97
            //2.b 98
            //3.c 99
            //4.d 100
            //5.e 101
            //6.f 102 
            //7.g 103
            //8.h 104
            //9.i 105
            //10.j 106
            //11.k 107
            //12.l 108
            //13.m 109
            //14.n 110
            //15.o 111
            //16.p 112
            //17.q 113
            //18.r 114
            //19.s 115
            //20.t 116
            //21.u 117
            //22.v 118
            //23.w 119
            //24.x 120
            //25.y 121
            //26.z 122

            //입력받은 소문자 알파벳
            string input = Console.ReadLine();

            //26의 크기를 가진 ap[]배열을 생성 하여 -1로 초기화

            int[] ap = new int[26];

            for (int i = 0; i < 26; i++)
            {
                ap[i] = -1;
            }

            //ap[]의 인덱스 0은 a, 1은 b ... 이런식으로 되어 있음.
            //input은 유니코드 값이므로 a일때 97이 되므로 
            //ap[a]에서 a가 0이 되기 위해서는 input[a] - 97 인데
            // 타입이 다르기 때문에 input[a] - 'a';

            for (int i = 0; i < input.Length; i++)
            {
                int num = input[i] - 'a';

                // 중복 입력된 알파벳은 최초 입력값만을 유지 시킴
                if (ap[num] == -1) ap[num] = i; ;
            }

            for (int i = 0; i < ap.Length; i++) {
                Console.Write(ap[i] + " ");
            }





        }
    }
}
