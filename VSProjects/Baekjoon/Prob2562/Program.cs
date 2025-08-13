namespace Prob2562
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int max = int.MinValue;
            //int num = 0;
            //int count = 0;
            //for (int i = 0; i < 9; i++)
            //{
            //    num = int.Parse(Console.ReadLine());

            //    if (max < num) {
            //        max = num;
            //        count = i + 1;
            //    }

            //}

            int[] arr = new int[9];
            for (int i = 0; i < 9; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = arr[0];
            int max = arr[0];
            int count = 1;

            for (int i = 1; i < 9; i++)
            {

                if (max < arr[i])
                {
                    max = arr[i];
                    count = i+1;
                }
            }

            Console.WriteLine($"{max}");
            Console.WriteLine($"{count}");
        }
    }
}
