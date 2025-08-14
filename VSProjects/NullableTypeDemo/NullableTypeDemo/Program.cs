namespace PPT08_NullableTypeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<bool> bln = null;
            bool? bln2 = null;

            Console.WriteLine(bln2.HasValue); //HasValue -> 값이 있으면 true, 없으면 false를 반환 <null일 경우 false 반환>

            bln2 = true;
            Console.WriteLine(bln2.HasValue);

            //int intValue = null; //null 값 저장 불가
            int? intvalue = null; // int? == Nullable<int>
            Nullable<int> ii = null;
            Console.WriteLine(ii);

        }
    }
}
