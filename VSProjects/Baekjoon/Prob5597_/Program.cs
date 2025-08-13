namespace Prob5597_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] numArr = new bool[31];

            for (int i = 1; i <= 28; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numArr[num] = true;
            }

            for (int i = 1; i <= 30; i++)
            {
                if (!numArr[i])
                {
                    Console.WriteLine(i);
                }
            }


            /*
            int n = 30;

            int[] a = new int[n];

            for (int i = 0; i < n - 2; i++)
            {
                string input = Console.ReadLine();
                a[i] = int.Parse(input);
                //a[i] = i+1;
                //Console.WriteLine("i : " + i);
            }

            a[28] = 0;
            a[29] = 31;
            Array.Sort(a);

            for (int i = 0; i < n - 1; i++)
            {
                int gap = a[i + 1] - a[i];
                //Console.Write(gap);
                //Console.WriteLine();

                if (gap == 2)
                {
                    Console.WriteLine(a[i] + 1);
                }
                else if (gap == 3)
                {
                    Console.WriteLine(a[i] + 1);
                    Console.WriteLine(a[i] + 2);
                }
            }

            //for (int i = 0; i < n; i++) Console.Write(i);

            */


        }
    }
}
