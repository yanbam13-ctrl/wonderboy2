namespace Prob2744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //string str = "WrongAnswer";
            string result = "";

            foreach (var item in str)
            {
                if (char.IsLower(item))
                {
                    result += char.ToUpper(item);
                }
                else if (char.IsUpper(item))
                {
                    result += char.ToLower(item);
                }
                else
                {
                    result += item;
                }
            }

            Console.WriteLine(result);



        }
    }
}
