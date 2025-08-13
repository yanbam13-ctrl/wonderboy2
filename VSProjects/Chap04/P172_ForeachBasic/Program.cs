namespace P172_ForeachBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
