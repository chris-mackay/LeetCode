using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace add_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddDigits(38));
            Console.ReadLine();
        }

        private static int AddDigits(int num)
        {
            int[] a = GetIntArray(num);
            bool f = false;
            int r = 0;

            while(!f)
            {
                r = 0;
                for (int i = 0; i < a.Length; i++) r += a[i];
                if (r.ToString().Length != 1) a = GetIntArray(r); else f = true;
            }

            return r;
        }

        private static int[] GetIntArray(int num)
        {
            List<int> l = new List<int>();
            while (num > 0)
            {
                l.Add(num % 10);
                num = num / 10;
            }
            l.Reverse();
            return l.ToArray();
        }
    }
}
