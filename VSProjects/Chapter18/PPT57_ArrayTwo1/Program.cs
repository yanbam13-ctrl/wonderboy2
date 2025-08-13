namespace PPT57_ArrayTwo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] intArray;
            intArray = new int[2, 3];

            //intArray[0, 0] = 1;
            //intArray[0, 1] = 2;
            //intArray[0, 2] = 3;
            //intArray[1, 0] = 4;
            //intArray[1, 1] = 5;
            //intArray[1, 2] = 6;

            int cnt = 1;


            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 2; i++)
                {

                    intArray[i, j] = cnt;
                    cnt++;

                    //Console.Write($"({i}, {j})_");
                    //Console.Write($"{intArray[i, j]}_");
                }
                //Console.WriteLine();
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //Console.Write($"({i}, {j})_");
                    Console.Write($"{intArray[i, j]}_");
                }
                Console.WriteLine();
            }
        }
    }
}
