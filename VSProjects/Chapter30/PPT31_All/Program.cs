namespace PPT31_All
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] completes = { true, true, true };
            //Console.WriteLine(completes.All(c => c == true));

            Console.WriteLine(All(completes));
        }

        static bool All(bool[] completes)
        {
            for (int i = 0; i < completes.Length; i++)
            {
                if (completes[i] != true)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
