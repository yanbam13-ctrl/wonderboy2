namespace PPT57_NewOverride
{
    class Parent
    {
        public void WorkNew() => Console.WriteLine("new - 부모 클래스");
        public virtual void WorkOverride() => Console.WriteLine("Override - 부모클래스");
    }
    class Child : Parent
    {
        public new void WorkNew() => Console.WriteLine("new - 자식클래스");
        public override void WorkOverride() => Console.WriteLine("Override - 자식클래스");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Child();
            parent.WorkNew();
            parent.WorkOverride();

        }
    }
}
