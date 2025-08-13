namespace PPT72_AsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object s = "반갑습니다.";
            string r1 = s as string;

            object i = 1234;
            string r2 = i as string;

            if (r2 == null) {
                Console.WriteLine("[2] null입니다.");
            }

            object i2 = 3456;
            if (i2 is string) {
                string r3 = i2 as string;
                Console.WriteLine($"[3] {r3}");
            }

            else Console.WriteLine("[3] 변환 불가");
        }
    }
}
