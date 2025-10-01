namespace PPT16_AttributePractice
{
    public class SampleAttribute : Attribute
    {
        public SampleAttribute() => Console.WriteLine("사용자 지정 특성 사용됨");
    }

    [Sample]
    public class CustomAttributeTest
    {

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Attribute.GetCustomAttributes(typeof(CustomAttributeTest));
        }
    }
}
