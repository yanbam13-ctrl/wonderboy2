namespace P152_Prob07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arr = { "원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양" };

            Console.WriteLine(arr.Length);

            while (true)
            {
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine($"{arr[year%12]} 띠입니다.");
            }



            // 1984 = 4 쥐
            // 1985 = 5 소
            // 1986 = 6 호랑이
            // 1987 = 7 토끼
            // 1988 = 8 용
            // 1989 = 9 뱀
            // 1990 = 10 말
            // 1991 = 11 양
            // 1992 = 0 원숭이
            // 1993 = 1 닭
            // 1994 = 2 개
            // 1995 = 3 돼지

            //===========
            //while (true)
            //{
            //    int year = int.Parse(Console.ReadLine());
            //    int result = year % 12;

            //    //Console.WriteLine(year % 12);

            //    switch (result)
            //    {
            //        case 4:
            //            Console.WriteLine("쥐 띠입니다.");
            //            break;
            //        case 5:
            //            Console.WriteLine("소 띠입니다.");
            //            break;
            //        case 6:
            //            Console.WriteLine("호랑이 띠입니다.");
            //            break;
            //        case 7:
            //            Console.WriteLine("토끼 띠입니다.");
            //            break;
            //        case 8:
            //            Console.WriteLine("용 띠입니다.");
            //            break;
            //        case 9:
            //            Console.WriteLine("뱀 띠입니다.");
            //            break;
            //        case 10:
            //            Console.WriteLine("말 띠입니다.");
            //            break;
            //        case 11:
            //            Console.WriteLine("양 띠입니다.");
            //            break;
            //        case 0:
            //            Console.WriteLine("원숭이 띠입니다.");
            //            break;
            //        case 1:
            //            Console.WriteLine("닭 띠입니다.");
            //            break;
            //        case 2:
            //            Console.WriteLine("개 띠입니다.");
            //            break;
            //        case 3:
            //            Console.WriteLine("돼지 띠입니다.");
            //            break;
            //        default:
            //            break;

            //    }
            //}


        }
    }
}
