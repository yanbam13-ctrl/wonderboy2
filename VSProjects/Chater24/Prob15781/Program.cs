using System;

namespace Prob15781
{
    internal class Program
    {
        static int getMaxNum(string[] str)
        {
            int maxNum = int.MinValue;

            for (int i = 0; i < str.Length; i++)
            {
                if (maxNum < int.Parse(str[i])) maxNum = int.Parse(str[i]);
            }

            return maxNum;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int h = int.Parse(input.Split()[0]);
            int a = int.Parse(input.Split()[1]);

            int maxH = int.MinValue;
            int maxA = int.MinValue;
            int totalNum = 0;

            for (int i = 0; i < 2; i++)
            {
                input = Console.ReadLine();
                string[] str = input.Split();

                totalNum += getMaxNum(str);
            }

            Console.WriteLine(totalNum);

        }
    }
}
