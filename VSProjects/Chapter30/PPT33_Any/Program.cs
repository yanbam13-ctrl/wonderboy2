namespace PPT33_Any
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, };
            bool bln = arr.Any(num => num == 2);
            Console.WriteLine(bln);
            Console.WriteLine(Any(arr));

            
        }
        static bool Any(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
