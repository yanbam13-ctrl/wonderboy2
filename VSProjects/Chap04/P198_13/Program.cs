namespace P198_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "1";
            string nextStr;

            Console.WriteLine($"1 : {str}");

            for (int i = 2; i <= 20; i++)
            {
                nextStr = "";
                int idx = 0;

                while (idx < str.Length) // 1 1 일 때, 0 < 2 
                {
                    nextStr += str[idx].ToString(); // " " + 1 = "1"
                    int cnt = 1;
                    while (idx < str.Length - 1 && str[idx] == str[idx + 1]) // true && true
                    {
                        // 1 
                        // 1 1
                        // 1 2
                        // 1 1 2 1
                        // 1 2 2 1 1 1
                        // 1 1 2 2 1 3


                        idx++;
                        cnt++;
                    }
                    nextStr += cnt.ToString();
                    idx++;

                }
                str = nextStr;
                Console.WriteLine($"{i} : {str}");
            }

        }
    }
}
