namespace Prob14681
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            int x = int.Parse(A);
            int y = int.Parse(B);

            if (x > 0)
            { //1사 분면
                if (y > 0) // x+ , y+
                {
                    Console.WriteLine(1);
                }
                else // x+ , y-
                {
                    Console.WriteLine(4);
                }
            }
            else
            {
                if (y > 0) // x-, y+
                {
                    Console.WriteLine(2);
                }
                else // x-, y-
                {
                    Console.WriteLine(3);
                }
            }


        }
    }
}
