namespace Prob11966
{
    internal class Program
    {
        static void Main(string[] args) //1073741824
        {
            int n = int.Parse(Console.ReadLine());

            if(IsSquare2(n))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }

        static bool IsSquare2(int n)
        {
            while (true)
            {
                if (n == 1)
                {
                    return true;
                }
                if (n == 0)
                {
                    return false; 
                }

                if (n % 2 == 0)
                {
                    n /= 2;

                    if (n == 1)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
