namespace PPT27_MaxMinFunction
{
    internal class Program
    {
        static int Min(int[] array)
        {
            int min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                min = array[i];
            }

            return min;
        }
        static int Max(int[] array)
        {
            int max = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            return max;
        }
        static int Max(int x, int y)
        {
            return (x > y) ? x : y;

        }

        static int Min(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        static void ArraySort(int[] array) {
            Array.Sort(array);
        }



        static void Main(string[] args)
        {
            int[] a = { 54, 21, 7, 4, 23, 45, 19, 32 };


            int max = Max(a);

            Console.WriteLine(max);
            Console.WriteLine(Min(-3, -5));
            Console.WriteLine(Min(a));


        }
    }
}
