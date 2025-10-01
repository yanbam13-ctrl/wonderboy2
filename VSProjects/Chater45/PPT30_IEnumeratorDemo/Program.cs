using System.Collections;

namespace PPT30_IEnumeratorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "닷넷코리아", "비주얼아카데미" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            IEnumerator List = names.GetEnumerator();
            while (List.MoveNext())
            {
                Console.WriteLine(List.Current);
            }
        }
    }
}
