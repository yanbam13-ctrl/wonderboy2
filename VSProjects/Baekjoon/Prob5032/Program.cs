namespace Prob5032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int e = int.Parse(input[0]); // 가지고 있는 빈병
            int f = int.Parse(input[1]); // 구한 빈병
            int c = int.Parse(input[2]); // 바꾸는데 필요한 빈병

            int sum = e + f;
            int emptBottle = 0;
            int getBottle = 0;

            while (sum >= c)
            {
                getBottle += sum / c;
                emptBottle = sum % c;
                sum = (sum / c) + emptBottle;
            }

            Console.WriteLine(getBottle);
        }
    }
}
