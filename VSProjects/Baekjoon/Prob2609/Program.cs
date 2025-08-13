namespace Prob2609
{
    internal class Program
    {

        //static int GetGCD(int a, int b)
        //{

        //    int min = Math.Min(a, b);
        //    int gcd = 0;

        //    for (int i = 1; i < min; i++)
        //    {
        //        if (a % i == 0 && b % i == 0)
        //        {
        //            gcd = i;
        //        }
        //    }

        //    return gcd;
        //}

        static int GetGCD(int a, int b)
        {

            int min = Math.Min(a, b);

            for (int i = min; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }

        static int GetLCM(int a, int b)
        {
            return (a * b) / GetGCD(a, b);
        }

        //static int GetLCM(int a, int b)
        //{
        //    for (int i = Math.Max(a, b); i < a * b; i++)
        //    {
        //        if (i % a == 0 && i % b == 0)
        //        {
        //            return i;
        //        }
        //    }
        //    return a * b;
        //}

        static void Main(string[] args)
        {
            //최대 공약수 나누어 떨어지는 값 중 가장 큰수
            //최소 공배수 두수를 배로 계산해 나갔을때 같은수중 가장 작은 수

            string input = Console.ReadLine();
            string[] arrInput = input.Split();

            int a = int.Parse(arrInput[0]);
            int b = int.Parse(arrInput[1]);

            Console.WriteLine(GetGCD(a, b));
            Console.WriteLine(GetLCM(a, b));

        }
    }
}


/*

 namespace Prob2609
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //최대 공약수 나누어 떨어지는 값 중 가장 큰수
            //최소 공배수 두수를 배로 계산해 나갔을때 같은수중 가장 작은 수

            string input = Console.ReadLine();
            string[] arrInput = input.Split();

            int a = int.Parse(arrInput[0]);
            int b = int.Parse(arrInput[1]);

            int HCFNumber = 0;

            //입력된 두 수 중에서 작은 수를 i로 설정
            //i를 1씩 줄여가면서 나누기, a와b를 i로 나누었을때 나머지가 0인 경우
            //그 i가 최대 공약수, break;
            for (int i = Math.Min(a, b); i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    HCFNumber = i;
                    break;
                }
            }

            int LCMNumber = Math.Max(a, b);

            while (true)
            {
                if (LCMNumber % a == 0 && LCMNumber % b == 0)
                {
                    break;
                }
                LCMNumber++;
            }


            //최대공약수 × 최소공배수 = 두 수의 곱
            //최소공배수 = 두수의 곱 / 최대공약수
            //int LCMNumber = (a*b)/ HCFNumber;

            Console.WriteLine(HCFNumber);
            Console.WriteLine(LCMNumber);


            /*
             * 
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);

            int HCFNumber = max % min;    //the highest common factor

            if (min % HCFNumber != 0) {
                HCFNumber = min % HCFNumber;    
            }


             81와 57:

             81 % 57 = 24

             57 % 24 = 9

             24 % 9 = 6

             9 % 6 = 3

             6 % 3 = 0 → 최대공약수 = 3

           int LCMNumber = 0;    //least common multiple

            //24 -> 1, 2, 3, 4, 6, 8, 12, 24
            //18 -> 1, 2, 3, 6, 9, 18

            //24 -> 24, 48, 72, 96
            //18 -> 18, 36, 54, 72, 90


            






        }
    }
}


 
 */