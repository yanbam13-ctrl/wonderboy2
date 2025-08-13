using System;
using System.Xml;

namespace Prob1924_
{
    internal class Program
    {
        static int GetTotalDays(int m, int d)
        {
            int[] daysOfMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int totalDays = 0;

            for (int i = 1; i < m; i++)
            {
                totalDays += daysOfMonth[i];
            }
            totalDays += d;

            return totalDays;
        }

        static void OutPut(int totalDays)
        {

            string[] daysStr = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

            Console.WriteLine(daysStr[totalDays % 7]); 

            //switch (totalDays % 7)
            //{
            //    case 0:
            //        Console.WriteLine("SUN");
            //        break;
            //    case 1:
            //        Console.WriteLine("MON");
            //        break;
            //    case 2:
            //        Console.WriteLine("TUE");
            //        break;
            //    case 3:
            //        Console.WriteLine("WED");
            //        break;
            //    case 4:
            //        Console.WriteLine("THU");
            //        break;
            //    case 5:
            //        Console.WriteLine("FRI");
            //        break;
            //    case 6:
            //        Console.WriteLine("SAT");
            //        break;
            //    default:
            //        break;

            //}
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int x = int.Parse(arrInput[0]);
            int y = int.Parse(arrInput[1]);

            int totalDays = GetTotalDays(x, y);
            OutPut(totalDays);

        }
    }
}
