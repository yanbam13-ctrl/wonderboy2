namespace PPT04_IndexerNote
{
    internal class Program
    {
        class Catalog
        {
            public string this[int index]
            {
                get
                {
                    return (index % 2 == 0) ? $"{index} : 짝수 반환" : $"{index}  : 홀수 반환";
                }
            }
        }
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            Console.WriteLine(catalog[0]);
            Console.WriteLine(catalog[1]);
            Console.WriteLine(catalog[2]);
        }
    }
}
