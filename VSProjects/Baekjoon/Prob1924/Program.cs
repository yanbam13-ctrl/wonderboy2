using System;

namespace Prob1924
{
    internal class Program
    {
        static string dayReturn(int n)
        {
            switch (n)
            {
                case 1:
                    return "MON";
                case 2:
                    return "TUE";
                case 3:
                    return "WED";
                case 4:
                    return "THU";
                case 5:
                    return "FRI";
                case 6:
                    return "SAT";
                case 0:
                    return "SUN";
                default:
                    return "null";
            }
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int mon = int.Parse(input[0]);
            int day = int.Parse(input[1]);

            int totalDay = day;

            for (int i = 1; i < mon; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                {
                    totalDay += 31;
                }
                else if (i == 2)
                {
                    totalDay += 28;
                }
                else totalDay += 30;

            }



            Console.WriteLine(dayReturn(totalDay % 7));
        }
    }
}
