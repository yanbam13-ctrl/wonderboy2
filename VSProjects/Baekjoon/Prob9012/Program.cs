namespace Prob9012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int tc = int.Parse(input);
            for (int i = 0; i < tc; i++)
            {
                input = Console.ReadLine();


                bool res = IsVPS(input);

                Console.WriteLine(res ? "YES" : "NO");
            }
        }

        static bool IsVPS(string input)
        {

            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '(')
                {
                    stack.Push('*');
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                        return false;

                    stack.Pop();
                }

            }
            if (stack.Count > 0)
            {
                return false;
            }

            return true;

        }
    }
}
