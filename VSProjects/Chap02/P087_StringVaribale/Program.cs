namespace P087_StringVaribale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "안녕하세요.";

            Console.WriteLine(message + "!");
            Console.WriteLine(message[0]); //안
            Console.WriteLine(message[1]); //녕
            Console.WriteLine(message[3]); //세

            char c = message[2];
            Console.WriteLine(c);

            int a = 10;
            int b = 20;
            int sum = a + b;
            string str = $"{a} 더하기 {b}는 {sum} 입니다.";
            Console.WriteLine(str);


            //Console.WriteLine("=================================");
            //Console.WriteLine("숫자를 입력하세요.");
            //string[] input = Console.ReadLine().Split();

            //int d = int.Parse(input[0]);
            //int f = int.Parse(input[0]);

            //Console.WriteLine($"입력한 숫자는 : {a} , {b} 입니다." );
            bool enterKey = true;
            while (enterKey)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("숫자를 입력하세요. 숫자 입력 후 space! 입력 완료후 enter!");
                string[] input = Console.ReadLine().Split();

                if (input.Length == 2 &&
                    int.TryParse(input[0], out int z) &&
                    int.TryParse(input[1], out int x))
                {

                    Console.WriteLine($"입력하신 숫자는 {z} 와 {x} 입니다.");
                    enterKey = false;
                }

                else
                {
                    Console.WriteLine("숫자를 다시 입력해주세요.");
                }
            }
        }
    }
}
