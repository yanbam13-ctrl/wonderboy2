namespace PPT13_ListGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lstNumbers = new List<int>();
            lstNumbers.Add(30);
            lstNumbers.Add(40);

            for (int i = 0; i < lstNumbers.Count; i++)
            {
                Console.WriteLine(lstNumbers[i]);
            }
            Console.WriteLine();

            foreach (var v in lstNumbers)
                Console.WriteLine(v);

            Console.WriteLine(lstNumbers.Contains(50));
            Console.WriteLine(lstNumbers.Contains(40));

            Console.WriteLine(lstNumbers.IndexOf(50));
            Console.WriteLine(lstNumbers.IndexOf(40));

            lstNumbers.Insert(1, 60);
            lstNumbers.Insert(1, 60);

            lstNumbers.Remove(60);
            PrintList(lstNumbers);

            lstNumbers.RemoveAt(1);
            PrintList(lstNumbers);

            lstNumbers.Insert(1, 70);
            PrintList(lstNumbers);
            lstNumbers.Sort();
            PrintList(lstNumbers);
            lstNumbers.Insert(1, 60);
            lstNumbers.Insert(1, 60);

            Console.WriteLine("??");
            Console.WriteLine(lstNumbers.Contains(60));
            Console.WriteLine(lstNumbers.IndexOf(60));

            lstNumbers.Reverse();
            PrintList(lstNumbers);

            int[] arrNumbers = lstNumbers.ToArray();

            lstNumbers.Clear();

            Console.WriteLine("***");
            PrintList(lstNumbers);


            Console.WriteLine("***");
            Console.WriteLine(lstNumbers.Count);

        }

        static void PrintList(List<int> lst)
        {
            foreach (var v in lst)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();
        }
    }
}
