namespace P145_ConditionWithString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력 : ");
            string line = Console.ReadLine();

            if (line.Contains("안녕")) {
                Console.WriteLine("안녕 하세요");
            }
            else
            {
                Console.WriteLine("^^");
            }

            line = line.Replace("안녕", "Hello");
            Console.WriteLine(line);
           
        }
    }
}
