using System;
using System.Collections.Generic;
using System.Linq;
   
namespace PPT25_ListOfChildToListOfParent
{
    interface A { }
    class B : A { }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<A> convertAll = (new List<B>()).ConvertAll(x => (A)x);
            List<A> astoff = (new List<B>()).Cast<A>().ToList();

            Console.WriteLine(convertAll);
            Console.WriteLine(astoff); ;
        }
    }
}
