using System.Reflection;

namespace PPT26_ReflectionGetMembers
{
    class Test
    {
        public static void TestMethod()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Test);
            MemberInfo[] members = t.GetMembers(BindingFlags.Static | BindingFlags.Public);

            foreach (var member in members)
            {
                Console.WriteLine("{0}", member.Name);
            }
        }
    }
}
