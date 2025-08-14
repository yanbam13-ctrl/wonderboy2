namespace PPT11_NullCoalescingOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nullValue = null;
            string message = "";

            if (nullValue == null)
            {
                message = "[1] null이면 새로운 값으로 초기화 합니다.";
            }
            else
            {
                message = nullValue;
            }
            Console.WriteLine(message);

            message = nullValue ?? "[2] null이면 새로운 값으로 초기화 합니다.";
            Console.WriteLine(message);

            nullValue = "Hello";
            message = nullValue ?? "[3] Nothing";
            Console.WriteLine(message);

            int? ii = null;
            int defulatValue = ii ?? -1;
            Console.WriteLine(defulatValue);

            int? x = null;
            int z = x ?? default;
            Console.WriteLine(z);

            bool? unknown = null;
            if (unknown ?? true) {
                Console.WriteLine("출력됨");
            }
        }
    }
}
