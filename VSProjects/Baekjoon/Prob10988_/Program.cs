namespace Prob10988_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();

            string[] strArray = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

            for (int i = 0; i < strArray.Length; i++)
            {
                str = str.Replace(strArray[i], "0");
            }

            Console.WriteLine(str.Length);

        }
    }
}
