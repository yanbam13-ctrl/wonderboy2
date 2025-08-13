using System.Text;

namespace Prob11728
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();

            int n = int.Parse(arrInput[0]);
            int m = int.Parse(arrInput[1]);

            int[] a = new int[n + 1];
            a[n] = int.MaxValue;

            int[] b = new int[m + 1];
            b[m] = int.MaxValue;

            input = Console.ReadLine();
            arrInput = input.Split();
            for (int k = 0; k < n; k++) a[k] = int.Parse(arrInput[k]);

            input = Console.ReadLine();
            arrInput = input.Split();
            for (int k = 0; k < m; k++) b[k] = int.Parse(arrInput[k]);

            int[] c = new int[n + m];

            int aIdx = 0;
            int bIdx = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n + m; i++)
            {
                if (a[aIdx] < b[bIdx])
                {
                    sb.Append(a[aIdx++] + " ");
                }
                else
                {
                    sb.Append(b[bIdx++] + " ");
                }
            }

            Console.WriteLine(sb.ToString());




            //if (n < m)
            //{
            //    while (i < n)
            //    {
            //        if (a[i] < b[j])
            //        {
            //            Console.Write(a[i] + " ");
            //            i++;
            //        }
            //        else
            //        {
            //            Console.Write(b[j] + " ");
            //            j++;
            //        }
            //    }
            //    while (j < m)
            //    {
            //        Console.Write(b[j] + " ");
            //        j++;
            //    }
            //}
            //else 
            //{
            //    while (j < m)
            //    {
            //        if (a[i] < b[j])
            //        {
            //            Console.Write(a[i] + " ");
            //            i++;
            //        }
            //        else
            //        {
            //            Console.Write(b[j] + " ");
            //            j++;
            //        }
            //    }
            //    while (i < n)
            //    {
            //        Console.Write(a[i] + " ");
            //        i++;
            //    }
            //}


        }
    }
}
