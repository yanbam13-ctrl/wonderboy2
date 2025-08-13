namespace Prob10807
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int size = int.Parse(Console.ReadLine());

             //int[] arr = new int[size];

            string[] input = Console.ReadLine().Split();

            int v = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                //arr[i] = int.Parse(input[i]);

                if (int.Parse(input[i]) == v){
                    count += 1;
                }
            }

            Console.WriteLine(count);



        }
    }
}
