using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT18_ClassDemo
{
    internal class ClassOne
    {
        static string name;
        public static void Hi()
        {
            name = "홍길동";
            Console.WriteLine(name + "님 안녕하세요.");
        }
    }
}
