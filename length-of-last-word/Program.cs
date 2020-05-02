using System;

namespace length_of_last_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "day";
            int i = LengthOfLastWord(s);
            Console.WriteLine(i);
        }

        public static int LengthOfLastWord(string s)
        {
            s = s.TrimEnd();
            if (s.Length == 0) return 0;
            if (s == " ") return 0;
            if (s.Length == 1) return 1;
            
            int l = 0;

            if (s.LastIndexOf(" ") != -1)
                l = s.Length - s.Substring(0, s.LastIndexOf(" ")).Length - 1;
            else
                l = s.Length;

            return l;
        }
    }
}
