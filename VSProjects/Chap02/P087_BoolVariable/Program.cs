namespace P087_BoolVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== bool ===========");
            bool one = 10 < 0;
            bool other = true;

            Console.WriteLine(one);
            Console.WriteLine(other);

            Console.WriteLine("============== 입력 받기 연습중 ===========");
            Console.WriteLine("============== 숫자를 입력하세요. ===========");
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            Console.WriteLine($"입력하신 숫자는 {a} , {b} 입니다.");
            Console.WriteLine($"입력하신 숫자의 합은 {a + b} 입니다.");

        }
    }
}
