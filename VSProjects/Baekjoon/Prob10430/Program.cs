namespace Prob10430
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]); //5
            int b = int.Parse(input[1]); //8
            int c = int.Parse(input[2]); //4

            Console.WriteLine((a+b)%c); //1
            Console.WriteLine(((a%c)+(b%c))%c); //1 0 1
            Console.WriteLine((a*b)%c);//0
            Console.WriteLine((a%c)*(b%c)%c); //1
        }
    }
}
