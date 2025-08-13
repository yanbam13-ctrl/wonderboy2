using System;

namespace Prob11720
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < num; i++) {

                sum += str[i] - '0';
            }

            Console.WriteLine(sum);


        }
    }
}