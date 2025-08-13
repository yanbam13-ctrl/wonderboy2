using System.Diagnostics.CodeAnalysis;

namespace Prob1284_
{
    internal class Program
    {
        static int GetWidth(char s)
        {
            int res = 0;
            //if (s == '1')
            //{
            //    res = 2;
            //    return res;
            //}
            //else if (s == '0')
            //{
            //    res = 4;
            //    return res;
            //}
            //else
            //{
            //    res = 3;
            //    return res;
            //}
            switch (s)
            {
                case '1': res = 2; return res;
                case '0': res = 4; return res;
                default: res = 3; return res;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "0") break;

                int sum = 0;

                for (int i = 0; i < input.Length; i++)
                {


                    sum += GetWidth(input[i]);

                    //if (i != input.Length - 1)
                    //{
                    //    sum += 1;
                    //}                    
                }
                sum += input.Length + 1;

                Console.WriteLine(sum + 2);
            }

        }
    }
}
