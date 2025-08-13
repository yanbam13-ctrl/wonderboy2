namespace P163_WhileBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //int[] intArray = { 52, 273, 32, 65, 103 };

            //while (i < intArray.Length)
            //{
            //    Console.WriteLine($"{i} 번째 출력 : {intArray[i]}");
            //    i++;
            //}

            //int a = 2;
            //while (a <= 10)
            //{


            //    Console.WriteLine(a);
            //    a += 2;
            //}

            //2 4 8 16 32 64

            int n = 1;
            
            while (n <= 100)
            {
                Console.WriteLine(n);
                n *= 2;
                //1
                //2
                //4
                //8
                //16
                //32
                //64

            }
        }
    }
}
