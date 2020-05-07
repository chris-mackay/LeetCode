using System;
using System.Collections.Generic;
using System.Linq;

namespace findluckyintegerinanarray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = { 2, 2, 2, 3, 3 };
            Console.WriteLine(FindLucky(a));
        }

        public static int FindLucky(int[] arr)
        {
            if (arr.Length == 0) return -1;
            if (arr.Length == 1 && arr[0] > 1) return -1;

            List<int> l = new List<int>();

            foreach (int n in arr)
            {
                int c = (from num in arr where num == n select num).Count();
                if (n == c && !l.Contains(n))
                    l.Add(n);
            }

            if (l.Count == 0) return -1;

            return l.Max();
        }

    }
}
