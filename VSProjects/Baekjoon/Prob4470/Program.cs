namespace Prob4470
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] strArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                int k = i + 1;
                strArray[i] = k.ToString();
                strArray[i] += ". ";
                strArray[i] += Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(strArray[i]);
            }
        }
    }
}
