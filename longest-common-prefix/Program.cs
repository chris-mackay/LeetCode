using System;

namespace longest_common_prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(a));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            // I had to look at the solution for this one...
            // Not proud of myself...
            
            if (strs.Length == 0) return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";
                }    

            return prefix;
        }
    }
}
