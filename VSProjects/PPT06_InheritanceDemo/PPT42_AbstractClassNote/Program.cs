namespace PPT42_AbstractClassNote
{
    public abstract class TableBase
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public abstract void SayHumor();
    }

    public class Children : TableBase
    {
        public string Name { get; set; }
        public override void SayHumor()
        {
            Console.WriteLine("1+1은? 노가다!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //TableBase tableBase = new TableBase(); // 추상 클래스는 객체를 만들수 없다.
            var child = new Children() { Id = 1, Active = true, Name = "아이" };
            if (child.Active)
            {
                Console.WriteLine($"{child.Id} - {child.Name}");
            }
            child.SayHumor();

        }
    }
}
