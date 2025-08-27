namespace PPT18_TypeDefinitionWithUsing
{
    using Project = Gilbut.Education.CSharp.Lecture;
    internal class Program
    {
        static void Main(string[] args)
        {
            Gilbut.Education.CSharp.Lecture L = new Gilbut.Education.CSharp.Lecture();

            Console.WriteLine(L);

            Project p = new Project();
            Console.WriteLine(p);
        }
    }
}

namespace Gilbut
{
    namespace Education
    {
        namespace CSharp
        {
            public class Lecture()
            {
                public override string ToString()
                {
                    return "Lecture 클래스 호출됨";
                }
            }
        }

    }
}

