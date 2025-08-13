namespace Prob1264
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                int cnt = 0;

                string str = Console.ReadLine();
                string nStr = str.Replace(" ", "");
                nStr = nStr.ToLower();

                if (nStr[0] == '#') break;

                for (int i = 0; i < nStr.Length; i++)
                {
                    if (nStr[i] == 'a' || nStr[i] == 'e' || nStr[i] == 'i' || nStr[i] == 'o' || nStr[i] == 'u') cnt++;
                }

                Console.WriteLine(cnt);


            }
        }
    }
}
