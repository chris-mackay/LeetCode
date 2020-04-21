using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(1534236469));
            Console.ReadLine();
        }

        public static int Reverse(int x)
        {
            int r = 0;

            if (x < 0 && x > int.MinValue)
            {
                char[] a = Math.Abs(x).ToString().ToCharArray();
                Array.Reverse(a);

                string s = "";
                foreach (char c in a) s += c;
                
                if (int.TryParse(s, out r))
                    return -r;
                else
                    return 0;
            }
            else if (x > 0 && x < int.MaxValue)
            {
                char[] a = x.ToString().ToCharArray();
                Array.Reverse(a);

                string s = "";
                foreach (char c in a) s += c;

                if (int.TryParse(s, out r))
                    return r;
                else
                    return 0;
            }
            else
                return 0;
        }
    }
}
