namespace Prob2845
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peopleNums = Console.ReadLine().Split();
            string[] newsNums = Console.ReadLine().Split();

            int peopleNum = int.Parse(peopleNums[0]) * int.Parse(peopleNums[1]);

            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] =int.Parse(newsNums[i]) - peopleNum;
            }

            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();


        }
    }
}
