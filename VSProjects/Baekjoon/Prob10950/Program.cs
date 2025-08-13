namespace Prob10950
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] output = new int[count];
            
            for (int i = 0; i < count; i++) { 
            string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                output[i] = a + b;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(output[i]);
            }


        }
    }
}
