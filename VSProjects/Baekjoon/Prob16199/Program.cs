namespace Prob16199
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] year = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int x = int.Parse(year[0]);
            int y = int.Parse(year[1]);
            int z = int.Parse(year[2]);

            int yearOne = 0;
            int yearTwo = 0;
            int yearThree = 0;

            if (y > b || (y == b && z >= c)) // 현재 월과 일이 태어난 날을 지난 경우
            {
                yearOne = x - a;
            }
            else
            {
                if (x - a != 0)
                {
                    yearOne = (x - a) - 1;
                }
                else
                {
                    yearOne = 0;
                }

            }

            yearTwo = x - a + 1;

            yearThree = x - a;

            Console.WriteLine(yearOne);
            Console.WriteLine(yearTwo);
            Console.WriteLine(yearThree);


        }
    }
}
