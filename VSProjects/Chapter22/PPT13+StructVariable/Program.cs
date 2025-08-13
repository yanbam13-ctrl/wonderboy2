namespace PPT13_StructVariable
{
    internal class Program
    {
        struct Product
        {
            public int id;
            public string title;
            public decimal price;
        }

        static void Main(string[] args)
        {
            Product product;

            product.id = 1;
            product.title = "좋은 책";
            product.price = 10000M;

            string message =
                $"번호 : {product.id}\n" +
                $"상품명 : {product.title}\n" +
                $"가격 : {product.price}\n";

            Console.WriteLine(message);


        }
    }
}
