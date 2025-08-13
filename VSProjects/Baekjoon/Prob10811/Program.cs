namespace Prob10811
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //입력 값          출력 값
            // 5 4            3 4 1 2 5

            // 1 2
            // 3 4
            // 1 4
            // 2 2

            // 1 2 3 4 5

            // 2 1 3 4 5
            // 2 1 4 3 5
            // 3 1 4 2 5
            // 3 1 4 2 5

            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int[] basket = new int[a];

            for (int i = 0; i < a; i++)
            {
                basket[i] = i + 1;
            }

            for (int i = 0; i < a; i++)
            {
                Console.Write(basket[i] + " ");
            }
            //Console.WriteLine();

            int temp = 0;
            
            for (int i = 0; i < b; i++)
            {
                string[] inputB = Console.ReadLine().Split();
                int begin = int.Parse(inputB[0]) - 1;
                int end = int.Parse(inputB[1]) - 1;

                while (begin < end) {

                    temp = basket[begin];
                    basket[begin] = basket[end];
                    basket[end] = temp;

                    begin++;
                    end--;
                }

            }

            for (int i = 0; i < a; i++) {
                Console.Write(basket[i] + " ");
            }

            Console.WriteLine();

        }
    }
}
