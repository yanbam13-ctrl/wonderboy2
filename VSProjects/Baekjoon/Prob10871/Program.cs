namespace Prob10871
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 5
            // 1 10 4 9 2 3 8 5 7 6

            //1 4 2 3

            string[] input = Console.ReadLine().Split();

            int count = int.Parse(input[0]);
            int num = int.Parse(input[1]);

            string[] inputNum = Console.ReadLine().Split();

            string result = "";
    

            for (int i = 0; i < count; i++) {
                int current = int.Parse(inputNum[i]);
                if (current < num)
                {
                    result += (current +" ");
                }
            }

            Console.WriteLine(result.Trim());



        }
    }
}
