using System;
using System.Text;

namespace reversestring
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "hello";
            char[] a = s.ToCharArray();
            ReverseString(a);
        }

        public static void ReverseString(char[] s)
        {
            Array.Reverse(s);
            StringBuilder sb = new StringBuilder();
            foreach (char c in s) sb.Append(c);
            Console.WriteLine(sb.ToString());
        }
    }
}
