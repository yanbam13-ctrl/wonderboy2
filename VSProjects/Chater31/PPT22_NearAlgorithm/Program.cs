namespace PPT22_NearAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;

            int[] numbers = { 0b1010, 0x14, 0b11110, 0x1B, 0b10001 }; //10, 20 , 30 , 27, 17
            int target = 25;
            int near = default;

            for (int i = 0; i < numbers.Length; i++)
            {
                int abs = Math.Abs(numbers[i] - target);
                if (abs < min)
                {
                    min = abs;
                    near = numbers[i];
                }
            }

            Console.WriteLine(target);
            Console.WriteLine(near);
        }
    }
}
