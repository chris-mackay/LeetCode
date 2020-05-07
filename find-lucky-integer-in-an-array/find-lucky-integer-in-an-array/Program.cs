using System;
using System.Collections.Generic;
using System.Linq;

namespace findluckyintegerinanarray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 2, 3, 3, 3 };
            Dictionary<int, int> d = new Dictionary<int, int>();

            foreach (int n in a)
            {
                int c = (from num in a where num == n select num).Count();
                if (!d.Keys.Contains(n))
                    d.Add(n, c);
            }

            foreach (KeyValuePair<int, int> entry in d)
                if (entry.Key == entry.Value)
                    Console.WriteLine("Number: {0}, and Count: {1}", entry.Key, entry.Value);

        }
    }
}
