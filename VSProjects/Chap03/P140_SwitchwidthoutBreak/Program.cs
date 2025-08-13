namespace P140_SwitchwidthoutBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("이번 달은 몇 월인가요 : ");

            //int input = int.Parse(Console.ReadLine());

            //switch (input)
            //{

            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("겨울 입니다.");
            //        break;

            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("봄 입니다.");
            //        break;

            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("여름 입니다.");
            //        break;

            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("가을 입니다.");
            //        break;

            //    default:
            //        Console.WriteLine("대체 어떤 행성에 살고 계신가요?");
            //        break;                 


            //}

            string str = "월";

            switch (str) {
                case "월":
                case "화":
                case "수":
                case "목":
                case "금":
                    Console.WriteLine("평일 입니다.");
                    break;

                case "토":
                case "일":
                    Console.WriteLine("주말 입니다.");
                    break;
            }
        }
    }
}
