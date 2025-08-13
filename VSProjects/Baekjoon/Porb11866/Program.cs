namespace Prob11866
{
    internal class Program
    {
        static void Main(string[] args)
        {   // 요세푸스 문제 0 (11866)
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int n = int.Parse(arrInput[0]);
            int k = int.Parse(arrInput[1]);

            // 코드 작성
            Sovle(n, k);
        }

        static void Sovle(int n, int k)
        {
            Queue<int> q = new Queue<int>();

            for (int i = 1; i <= n; i++)
            {
                q.Enqueue(i);
            }

            Console.Write('<');
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < k - 1; j++)
                {
                    q.Enqueue(q.Dequeue());
                }
                Console.Write(q.Dequeue() + ", ");
            }


            Console.Write(q.Dequeue() + ">");
        }

    }
}