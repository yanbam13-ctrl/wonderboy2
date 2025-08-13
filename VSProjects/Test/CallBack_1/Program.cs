namespace CallBack_1
{
    internal class Program
    {
        static void evenPrint(int i, int n)
        {
            if (n < i) return;
            
            if (i % 2 == 0)
            {
                Console.WriteLine(i);

            }
                evenPrint(i+1,n);
        }
        static void Main(string[] args)
        {
            //1부터 N까지 수 중 짝수만 오름차순으로 출력

            int n = 6;

            evenPrint(1, n);

        }
    }
}
