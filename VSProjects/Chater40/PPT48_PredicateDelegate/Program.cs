namespace PPT48_PredicateDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isNullOrEmpty = string.IsNullOrEmpty;
            Console.WriteLine(isNullOrEmpty("")); 
        }
    }
}
