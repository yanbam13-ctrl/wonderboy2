namespace PPT84_ArrayWithVarKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 5;
            Console.WriteLine("i = {0}, 타입 : {1}", i, i.GetType());

            var numbers = new int[] { 1, 2, 3 };
            foreach (var item in numbers)
            {
                Console.WriteLine("item : {0}, 타입 {1}", item, item.GetType());
            }
            Console.WriteLine("numbers : {0}, 타입{1}", numbers, numbers.GetType());
        }
    }
}
