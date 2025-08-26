namespace PPT25_ToStringMethod
{

    class My { }

    class Your {
        public override string ToString()
        {
            return "새로운 반환 문자열 지정";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            My my = new My();
            Your your = new Your();

            Console.WriteLine(my.ToString());

            Console.WriteLine(your.ToString());

            Your aa = new Your();

            Console.WriteLine(aa);
           
            
        }
    }
}
