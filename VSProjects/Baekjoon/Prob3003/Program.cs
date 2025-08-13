namespace Prob3003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            for (int i = 0; i < str.Length; i++) {
                int num = int.Parse(str[i]);

                if (i < 2)
                {
                    Console.Write(1 - num + " ");
                }
                else if (i < 5)
                {
                    Console.Write(2 - num + " ");
                }
                else {
                    Console.Write(8 - num + " ");
                }
            }

            //int a = int.Parse(str[0]);
            //int b = int.Parse(str[1]);
            //int c = int.Parse(str[2]);
            //int d = int.Parse(str[3]);
            //int e = int.Parse(str[4]);
            //int f = int.Parse(str[5]);

            //Console.Write(1-a + " ");
            //Console.Write(1-b + " ");
            //Console.Write(2-c + " ");
            //Console.Write(2-d + " ");
            //Console.Write(2-e + " ");
            //Console.Write(8-f);
            //Console.WriteLine();

        }
    }
}
