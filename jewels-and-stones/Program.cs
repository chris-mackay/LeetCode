using System;

namespace jewelsandstones
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string j = "aA";
            string s = "aAAbbbb";
            Console.WriteLine(NumJewelsInStones(j, s).ToString());
        }

        public static int NumJewelsInStones(string J, string S)
        {
            int n = 0;
            char[] a = J.ToCharArray();
            foreach (char c in a)
                foreach (char ci in S)
                if (c.ToString() == ci.ToString()) n++;

            return n;
        }
    }
}
