using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace longest_common_prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "ba", "bb", "ba" };
            Console.WriteLine(LongestCommonPrefix(a));
            Console.ReadLine();
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            int min = strs.Min(y => y.Length);
            List<string> prefixes = new List<string>();

            do
            {
                prefixes.Clear();

                for (int i = 0; i <= strs.Length - 1; i++)
                    if (strs[i].Length > min)
                        prefixes.Add(strs[i].Remove(min));
                    else
                        prefixes.Add(strs[i]);

                min--;

            } while (!AllMatch(prefixes));

            return prefixes[0];
        }

        public static bool AllMatch(List<string> list)
        {
            if (list.All(x => x == list.First()))
                return true;
            else
                return false;
        }
    }
}
