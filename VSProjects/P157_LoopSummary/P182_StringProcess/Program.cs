namespace P182_StringProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());

            input = "감자 고구마 토마토";
            string[] inputs = input.Split(' ');
            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }

            input = "감자,고구마|토마토";
            inputs = input.Split(new char[] { ',', '|' });
            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }

            input = " test     \n";
            Console.WriteLine("::" + input.Trim() + "::");

            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));

        }
    }
}
