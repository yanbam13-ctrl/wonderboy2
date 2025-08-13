namespace Prob1251
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // string input = Console.ReadLine();

            string str = "mobitel";

            string nStr = new string(str.Substring(7));

            // m / o, ob, obi, obit, obite / l
            // mo / b , bi, bit, bite / l
            // mob / i, ite / l
            // mobi / t,  te / l
            // mobite / 

            Console.WriteLine(str.Substring(7) == "");

            Console.WriteLine(string.Compare("moletib","mboleti"));
           

        }
    }
}


//namespace Prob1251
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            string input = Console.ReadLine();
//            //string input = "abcdefghijk";//0 1 2 3 4 5 6 7
//            char[] charArray = input.ToCharArray();

//            string temp = "";
//            if (charArray.Length <= 4) // 길이가 3~4일 경우
//            {
//                for (int i = charArray.Length - 1; i >= 0; i--)
//                {
//                    temp += charArray[i];
//                }
//                //temp += charArray[2].ToString();
//                //temp += charArray[1].ToString();
//                //temp += charArray[0].ToString();
//                Console.WriteLine(temp);
//            }
//            //else if (charArray.Length == 4)
//            //{
//            //    for(int i = 0; i < char)
//            //    temp += charArray[3];
//            //    temp += charArray[2];
//            //    temp += charArray[1];
//            //    temp += charArray[0];
//            //    Console.WriteLine(temp);
//            //}
//            else
//            {
//                //charArray.length = 4; 0~3
//                // 4 / 2 = 2;

//                //string a = input[0].ToString() + input[1].ToString();
//                string a = "";
//                for (int i = 1; i >= 0; i--)
//                {
//                    a += input[i].ToString();
//                    //Console.Write(i + " ");
//                }

//                //string b = input[2].ToString() + input[3].ToString() + input[4].ToString() + input[5].ToString();
//                string b = "";
//                for (int i = input.Length - 3; i >= 2; i--)
//                {
//                    b += input[i].ToString();
//                    //Console.Write(i + " ");
//                }

//                //string c = input[6].ToString() + input[7].ToString();
//                string c = "";
//                for (int i = input.Length - 1; i >= input.Length - 2; i--)
//                {
//                    c += input[i].ToString();
//                    //Console.Write(i + " ");
//                }


//                //string aA = "";
//                ////aA += a[1].ToString();
//                ////aA += a[0].ToString();

//                //for (int i = 1; i >= 0; i--)
//                //{
//                //    aA += a[i];
//                //}

//                //string bB = "";
//                ////bB += input[5].ToString();
//                ////bB += input[4].ToString();
//                ////bB += input[3].ToString();
//                ////bB += input[2].ToString();

//                //for (int i = 3; i >= 0; i--)
//                //{
//                //    bB += b[i];
//                //}

//                //string cC = "";
//                ////cC += input[7].ToString();
//                ////cC += input[6].ToString();

//                //for (int i = 1; i >= 0; i--)
//                //{
//                //    cC += c[i];
//                //}

//                string abc = "";
//                //abc = aA + bB + cC;
//                abc = a + b + c;

//                Console.WriteLine(abc);
//            }
//        }
//    }
//}
