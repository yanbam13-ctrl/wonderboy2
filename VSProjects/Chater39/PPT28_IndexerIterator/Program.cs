using System.Collections;
using System.Linq.Expressions;

namespace PPT28_IndexerIterator
{
    public class Language
    {
        private string[] languages;

        public Language(int length)
        {
            languages = new string[length];
        }

        public string this[int index]
        {
            get { return languages[index]; }
            set { languages[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < languages.Length; i++)
            {
                yield return languages[i];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var language = new Language(2);
            language[0] = "C#";
            language[1] = "TypeScript";
            foreach (var lang in language)
            {
                Console.WriteLine(lang);
            }
        }
    }
}
